using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;

namespace LogManipulate
{
    // TODO: buff系　debuff系の解析
    // 術・魔法　開始
    // アイテム使用

    public class FF14LogParser
    {
        List<FFXIVLogDataSet.AnaylzedRow> DotRowList = new List<FFXIVLogDataSet.AnaylzedRow>();

        public static string UnknownName
        {
            get { return "unknown"; }
        }

        public FFXIVLogDataSet ds
        {
            get;
            private set;
        }

        public FF14LogParser()
        {
            ds = new FFXIVLogDataSet();
            ds.Anaylzed.TableCleared += new DataTableClearEventHandler(Anaylzed_TableCleared);
            SetAction();
        }

        void Anaylzed_TableCleared(object sender, DataTableClearEventArgs e)
        {
            DotRowList.Clear();
        }

        public void Write(string filename)
        {
            string temp = Path.GetTempFileName();
            //作成する圧縮ファイルのFileStreamを作成する
            System.IO.FileStream compFileStrm =
                new System.IO.FileStream(temp, System.IO.FileMode.Create);
            //圧縮モードのGZipStreamを作成する
            System.IO.Compression.GZipStream gzipStrm =
                new System.IO.Compression.GZipStream(compFileStrm,
                    System.IO.Compression.CompressionMode.Compress);

            //ファイルに書き込む
            ds.WriteXml(gzipStrm);

            gzipStrm.Close();
            File.Copy(temp, filename, true);
            try
            {
                File.Delete(temp);
            }
            catch
            {
            }
        }

        /// <summary>
        /// ファイル読み込み等の状況を取得します
        /// </summary>
        public int Progress
        {
            get;
            private set;
        }


        public void Read(string filename)
        {
            //展開する書庫のFileStreamを作成する
            System.IO.FileStream gzipFileStrm = new System.IO.FileStream(
                filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            //圧縮解除モードのGZipStreamを作成する
            System.IO.Compression.GZipStream gzipStrm =
                new System.IO.Compression.GZipStream(gzipFileStrm,
                    System.IO.Compression.CompressionMode.Decompress);

            //string temp = Path.GetTempFileName();

            //展開先のファイルのFileStreamを作成する
            //System.IO.FileStream outFileStrm = new System.IO.FileStream(
            //    temp, System.IO.FileMode.Create, System.IO.FileAccess.Write);

            System.IO.MemoryStream outFileStrm = new MemoryStream();


            byte[] buffer = new byte[10240];
            while (true)
            {
                //書庫から展開されたデータを読み込む
                int readSize = gzipStrm.Read(buffer, 0, buffer.Length);
                //最後まで読み込んだ時は、ループを抜ける
                if (readSize == 0)
                    break;
                //展開先のファイルに書き込む
                outFileStrm.Write(buffer, 0, readSize);
            }
            //閉じる
            //outFileStrm.Close();
            gzipStrm.Close();

            ds.Clear();
            outFileStrm.Position = 0;
            ds.ReadXml(outFileStrm);
        }


        /// <summary>
        /// ログを追加する
        /// </summary>d
        /// <param name="log"></param>
        /// <returns></returns>
        public FFXIVLogDataSet.AnaylzedRow Add(FFXIVLog log)
        {
            FFXIVLogDataSet.AnaylzedRow arow = ds.Anaylzed.NewAnaylzedRow();
            arow.Body = log.LogBodyReplaceTabCode;

            arow.TotalSeconds = log.TotalSeconds;
            arow.ServerTime = log.TimeStampServerTime;
            arow.LocalTime = log.TimeStampServerTime.AddHours(9);
            arow.ActionType = log.ActionType;
            arow.LogType = log.LogType;

            arow.FLAG_WHO = log.LogType / 4;
            arow.FLAG_TO = log.LogType & 3;
            arow.FLAG_FIGHT = log.ActionType / 128;
            arow.FLAG_INFO = log.ActionType / 16;
            arow.FLAG_UNKNOWN = log.ActionType / 4;
            arow.FLAG_NUM = log.ActionType & 7;


            ds.Anaylzed.AddAnaylzedRow(arow);

            if (log.WHO != LOG_CATEGORY_WHO.SYSTEM && log.LOG_TYPE == LOG_CATEGORY_TYPE.BATTLE)
            {
                if (log.BATTLE_TYPE == LOG_BATTLE_TYPE.HIT)// log.ActionType == 0xA9 || log.ActionType == 0x29)//A9と29があるのはなぜだろう
                {
                    HitAnalyze(arow, log);
                }
                else if (log.BATTLE_TYPE == LOG_BATTLE_TYPE.DONE)// log.ActionType == 0x2B||log.ActionType == 0xAB)
                {
                    ActionStartDoneAnalyze(arow, log);
                }
                else if (log.BATTLE_TYPE == LOG_BATTLE_TYPE.MISS)// log.ActionType == 0xAA||log.ActionType==0x2A)//AAと2Aがある
                {
                    DodgeAnalyze(arow, log);
                }
                else if (log.BATTLE_TYPE == LOG_BATTLE_TYPE.EFFECT1 || log.BATTLE_TYPE == LOG_BATTLE_TYPE.EFFECT2)// log.ActionType == 0xAE || log.ActionType == 0x2E)//ON OFFが表示される効果
                {
                    EffectAnalyze(arow, log);
                }
                else if (log.BATTLE_TYPE == LOG_BATTLE_TYPE.HEAL)//log.ActionType == 0xAD || log.ActionType == 0x2D)
                {
                    CureAnalyze(arow, log);
                }
            }
            else if (log.LOG_TYPE == LOG_CATEGORY_TYPE.GAME_EVENT)
            {
                if (log.GAME_EVENT_TYPE == LOG_GAME_EVENT_TYPE.DOWN_KO)//log.ActionType == 0xBA || log.ActionType == 0x3A)
                {//倒されたとき
                    KOAnaylyze(arow, log);
                    if (arow.IsKO)
                    {
                        CloseDot(arow.To, arow, false);//ひとつ閉じる
                        FFXIVLogDataSet.ActorRow acrow = ds.Actor.FindByName(arow.To);
                        if (acrow != null)
                        {
                            arow.EnemyGroupID = acrow.GroupCount;
                        }
                    }
                }
                else if (log.GAME_EVENT_TYPE == LOG_GAME_EVENT_TYPE.EVENT)// log.ActionType == 0x39)
                {//コンテンツの開始等
                    ContentStartEnd(arow, log);
                    LevelSyncStartEnd(arow, log);
                    if (log.LogBodyReplaceTabCode.Contains("チェンジ"))
                    {//ジョブチェンジ
                        Regex regex = new Regex(@":(?<name>[A-Z][a-z']+? [A-Z][a-z']+?)は「(?<jobclass>\w+?)」にチェンジした。");// :Choco Ponは「白魔道士」にチェンジした。
                        Match match = regex.Match(log.LogBodyReplaceTabCode);
                        if (match.Success)
                        {
                            string name = match.Groups["name"].Value;
                            string jobclass = match.Groups["jobclass"].Value;
                            FFXIVLogDataSet.ActorRow actor = ds.Actor.FindByName(name);
                            if (actor != null)
                            {
                                actor.ClassJob = jobclass;
                            }
                        }
                    }
                }
            }

            //TO と FROM
            FFXIVLogDataSet.ActorRow acrow_from = null;
            FFXIVLogDataSet.ActorRow acrow_to = null;


            if (!arow.IsToNull() && arow.To != "" && arow.To != FF14LogParser.UnknownName)
            {//Toに名前が入っていれば
                acrow_to = ds.Actor.FindByName(arow.To);
                bool need = false;
                if (acrow_to == null)
                {
                    need = true;
                    acrow_to = ds.Actor.NewActorRow();
                    acrow_to.Name = arow.To;
                    acrow_to.FirstLogID = arow.ID;
                    acrow_to.LastLogID = arow.ID;
                    acrow_to.LastSeconds = arow.TotalSeconds;
                    acrow_to.GroupCount = 1;
                    ds.Actor.AddActorRow(acrow_to);
                }
                else
                {
                    need = false;
                    if (arow.TotalSeconds - acrow_to.LastSeconds > 60)
                    {//最後にみてから60秒以上経過していれば、更新する
                        //DOT閉じる
                        CloseDot(arow.To, arow, true);
                        acrow_to.GroupCount++;//名前が同じだが、別グループである
                        need = true;
                    }
                    acrow_to.LastLogID = arow.ID;
                    acrow_to.LastSeconds = arow.TotalSeconds;
                    arow.EnemyGroupID = acrow_to.GroupCount;

                }

                //Toのカテゴリわけ
                //Actorを更新する
                if (need)// FFXIVLog.GetBATTLE_TYPE(arow.ac (arow.ActionType == 0x2B || arow.ActionType == 0xAB))
                {
                    acrow_to.IsMe = false;
                    acrow_to.IsMyPet = false;
                    acrow_to.IsPTMember = false;
                    acrow_to.IsPTPet = false;
                    acrow_to.IsNPC = false;
                    acrow_to.IsAllianceMember = false;

                    if (arow.FLAG_TO == (int)LOG_CATEGORY_TO.EMPTY_OR_ME)
                    {//ME
                        int ptype = GetPlayerTypeFromName(acrow_to.Name);
                        if (ptype == 0)
                        {
                            acrow_to.IsMe = true;
                        }
                        else if (ptype == 1)
                        {
                            acrow_to.IsMyPet = true;
                        }
                        else
                        {
                            acrow_to.IsNPC = true;
                        }
                    }
                    else if (arow.FLAG_TO == (int)LOG_CATEGORY_TO.PTMEMBER)
                    {//PT
                        int ptype = GetPlayerTypeFromName(acrow_to.Name);
                        if (ptype == 0)
                        {
                            acrow_to.IsPTMember = true;
                        }
                        else if (ptype == 1)
                        {
                            acrow_to.IsPTPet = true;
                        }
                        else
                        {
                            acrow_to.IsNPC = true;
                        }
                    }
                    else if (arow.FLAG_TO == (int)LOG_CATEGORY_TO.ENEMY)
                    {
                        int ptype = GetPlayerTypeFromName(acrow_to.Name);
                        if (ptype == 0)
                        {
                            acrow_to.IsOther = true;
                        }
                        else if (ptype == 1)
                        {
                            acrow_to.IsOther = true;
                        }
                        else
                        {
                            acrow_to.IsNPC = true;
                        }
                    }
                    else if (arow.FLAG_TO == (int)LOG_CATEGORY_TO.OTHER)
                    {
                        int ptype = GetPlayerTypeFromName(acrow_to.Name);
                        if (ptype == 0 || ptype == 1)
                        {
                            acrow_to.IsOther = true;
                        }
                        else
                        {
                            acrow_to.IsNPC = true;
                        }
                    }
                    else
                    {
                    }
                }

            }//TOの処理END

            if (!arow.IsFromNull() && arow.From != "" && arow.From != FF14LogParser.UnknownName)
            {//Fromに名前が入っていれば
                //bool need = false;
                acrow_from = ds.Actor.FindByName(arow.From);
                if (acrow_from == null)
                {
                    // need = true;
                    acrow_from = ds.Actor.NewActorRow();
                    acrow_from.Name = arow.From;
                    acrow_from.FirstLogID = arow.ID;
                    acrow_from.LastLogID = arow.ID;
                    acrow_from.LastSeconds = arow.TotalSeconds;
                    acrow_from.GroupCount = 1;
                    ds.Actor.AddActorRow(acrow_from);
                }
                else
                {
                    // need = false;
                    if (arow.TotalSeconds - acrow_from.LastSeconds > 60)
                    {//最後にみてから60秒以上経過していれば、更新する
                        //DOT閉じる
                        CloseDot(arow.From, arow, true);
                        acrow_from.GroupCount++;//名前が同じだが、別グループである
                        // need = true;
                    }
                    acrow_from.LastLogID = arow.ID;
                    acrow_from.LastSeconds = arow.TotalSeconds;
                    arow.EnemyGroupID = acrow_from.GroupCount;

                }
                //DOTのDamageBaseを設定する
                FFXIVLogDataSet.ActionRow action = null;
                if (!arow.IsNumericNull() && arow.ActionName != "攻撃")
                {
                    action = ds.Action.FindByName(arow.ActionName);
                    if (action != null && action.DD威力 > 0)
                    {
                        if (action.Name != "サンダガ" 
                            && action.Name != "ファイア" 
                            && action.Name != "ファイラ" 
                            && action.Name != "ファイガ" 
                            && action.Name != "フレア"
                            && action.Name !="インパルスドライブ")
                        {
                            double bai = 1.0;
                            if (arow.IsCritical)
                            {
                                bai = 1.5;
                            }
                            if (arow.BonusRate > 0)
                            {
                                bai = (100 + arow.BonusRate) / 100.0;
                            }
                            acrow_from.DamageBase = (double)arow.Numeric / bai / action.DD威力;
                        }
                    }
                }
                //Actorを更新する
                if (true)//(need)// FFXIVLog.GetBATTLE_TYPE(arow.ac (arow.ActionType == 0x2B || arow.ActionType == 0xAB))
                {
                    acrow_from.IsMe = false;
                    acrow_from.IsMyPet = false;
                    acrow_from.IsPTMember = false;
                    acrow_from.IsPTPet = false;
                    acrow_from.IsNPC = false;
                    acrow_from.IsAllianceMember = false;

                    if (arow.LogType >= 0x04 && arow.LogType <= 0x07)
                    {//ME
                        int ptype = GetPlayerTypeFromName(acrow_from.Name);
                        if (ptype == 0)
                        {
                            acrow_from.IsMe = true;
                        }
                        else if (ptype == 1)
                        {
                            acrow_from.IsMyPet = true;
                        }
                        else
                        {
                            acrow_from.IsNPC = true;
                        }
                    }
                    else if (arow.LogType >= 0x08 && arow.LogType <= 0x0B)
                    {//PT
                        int ptype = GetPlayerTypeFromName(acrow_from.Name);
                        if (ptype == 0)
                        {
                            acrow_from.IsPTMember = true;
                        }
                        else if (ptype == 1)
                        {
                            acrow_from.IsPTPet = true;
                        }
                        else
                        {
                            acrow_from.IsNPC = true;
                        }
                    }
                    else if (arow.LogType >= 0x0C && arow.LogType <= 0x0F)
                    {//Ally
                        int ptype = GetPlayerTypeFromName(acrow_from.Name);
                        if (ptype == 0 || ptype == 1)
                        {
                            acrow_from.IsAllianceMember = true;
                        }
                        else
                        {
                        }
                    }
                    else if (arow.LogType >= 0x10 && arow.LogType <= 0x13)
                    {
                        int ptype = GetPlayerTypeFromName(acrow_from.Name);
                        if (ptype == 0)
                        {
                            acrow_from.IsOther = true;
                        }
                        else if (ptype == 1)
                        {
                            acrow_from.IsOther = true;
                        }
                        else
                        {
                        }
                    }
                    else if (arow.LogType >= 0x14)
                    {
                        int ptype = GetPlayerTypeFromName(acrow_from.Name);
                        if (ptype == 0 || ptype == 1)
                        {
                            acrow_from.IsOther = true;
                        }
                        else
                        {
                            acrow_from.IsNPC = true;
                        }
                    }
                    else
                    {
                    }
                    if (action != null && (acrow_from.IsMe || acrow_from.IsPTMember || acrow_from.IsOther))
                    {//クラス・ジョブの設定
                        if (acrow_from.IsClassJobNull())
                        {
                            acrow_from.ClassJob = action.Class;
                        }
                        else
                        {
                            List<string> classes = new List<string>(action.Class.Split(new char[] { ' ' }));
                            List<string> forecast_classes = new List<string>(acrow_from.ClassJob.Split(new char[] { ' ' }));
                            List<string> new_classes = new List<string>();
                            foreach (string cls in forecast_classes)
                            {
                                if (classes.Contains(cls))
                                {
                                    new_classes.Add(cls);
                                }
                            }
                            if (new_classes.Count > 0)
                            {
                                acrow_from.ClassJob = String.Join(" ", new_classes.ToArray());
                            }
                            else
                            {
                                acrow_from.ClassJob = action.Class;
                            }
                        }
                    }


                }

            }
            //if ((acrow_from!=null&&acrow_from.Name.Contains("カーバンクル")) && (acrow_to!=null && acrow_to.Name == "オチュー"))
            //{
            //}
            //FROMの処理END
            //EnemyGroup処理 自分・味方から⇒敵に攻撃
            if (((acrow_from != null && acrow_from.Name != FF14LogParser.UnknownName) && (acrow_to != null && acrow_to.Name != FF14LogParser.UnknownName)) && (acrow_from.IsMe || acrow_from.IsMyPet || acrow_from.IsPTMember || acrow_from.IsPTPet))
            {
                if (!arow.IsActionNameNull())
                {
                    FFXIVLogDataSet.ActionRow action = ds.Action.FindByName(arow.ActionName);
                    if ((action != null && action.IsAttack && !arow.IsCure) || arow.ActionName == "攻撃")
                    {
                        FFXIVLogDataSet.EnemyGroupRow eg = ds.EnemyGroup.FindByName(acrow_to.Name);
                        if (eg == null)
                        {
                            eg = ds.EnemyGroup.NewEnemyGroupRow();
                            eg.Name = acrow_to.Name;
                            eg.FirstID = arow.ID;
                            eg.FirstSeconds = arow.TotalSeconds;
                            eg.LastID = arow.ID;
                            eg.LastSeconds = arow.TotalSeconds;
                            eg.KOCount = 0;
                            eg.Count = 1;
                            ds.EnemyGroup.AddEnemyGroupRow(eg);
                        }
                        else
                        {
                            if (eg.LastSeconds < arow.TotalSeconds - 60)
                            {
                                //Dotを閉じる
                                CloseDot(eg.Name, arow, true);

                                eg.FirstID = arow.ID;
                                eg.FirstSeconds = arow.TotalSeconds;
                                eg.LastID = arow.ID;
                                eg.LastSeconds = arow.TotalSeconds;
                                eg.KOCount = 0;
                                eg.Count = 1;

                            }
                            else if (arow.FLAG_TO == (int)LOG_CATEGORY_TO.OTHER)
                            {
                                eg.LastID = arow.ID;
                                eg.LastSeconds = arow.TotalSeconds;
                                eg.Count++;
                            }
                            else
                            {
                                eg.LastID = arow.ID;
                                eg.LastSeconds = arow.TotalSeconds;
                            }

                        }
                    }
                }
            }
            //EnemyGroup処理　敵⇒自分味方への攻撃
            if (((acrow_from != null && acrow_from.Name != FF14LogParser.UnknownName) && (acrow_to != null && acrow_to.Name != FF14LogParser.UnknownName)) && (acrow_to.IsMe || acrow_to.IsMyPet || acrow_to.IsPTMember || acrow_to.IsPTPet))
            {
                if (arow.FLAG_WHO == (int)LOG_CATEGORY_WHO.NPC)
                {
                    FFXIVLogDataSet.EnemyGroupRow eg = ds.EnemyGroup.FindByName(acrow_from.Name);
                    if (eg == null)
                    {
                        eg = ds.EnemyGroup.NewEnemyGroupRow();
                        eg.Name = acrow_from.Name;
                        eg.FirstID = arow.ID;
                        eg.FirstSeconds = arow.TotalSeconds;
                        eg.LastID = arow.ID;
                        eg.LastSeconds = arow.TotalSeconds;
                        eg.KOCount = 0;
                        eg.Count = 1;
                        ds.EnemyGroup.AddEnemyGroupRow(eg);
                    }
                    else
                    {
                        if (eg.LastSeconds < arow.TotalSeconds - 60)
                        {
                            //Dotを閉じる
                            CloseDot(eg.Name, arow, true);

                            eg.FirstID = arow.ID;
                            eg.FirstSeconds = arow.TotalSeconds;
                            eg.LastID = arow.ID;
                            eg.LastSeconds = arow.TotalSeconds;
                            eg.KOCount = 0;
                            eg.Count = 1;
                        }
                        else if (arow.FLAG_WHO == (int)LOG_CATEGORY_WHO.NPC)
                        {
                            eg.LastID = arow.ID;
                            eg.LastSeconds = arow.TotalSeconds;
                            eg.Count++;
                        }
                        else
                        {
                            eg.LastID = arow.ID;
                            eg.LastSeconds = arow.TotalSeconds;
                        }

                    }
                }
            }

            //DOTをとじる
            for (int i = DotRowList.Count-1; i >=0 ; i--)
            {
                if ( DotRowList[i].IsDamageBaseNull() || DotRowList[i].DamageBase==0)
                {
                    FFXIVLogDataSet.ActorRow actor = ds.Actor.FindByName(DotRowList[i].From);
                    if (actor != null &&!actor.IsDamageBaseNull()&& actor.DamageBase>0)
                    {
                        DotRowList[i].DamageBase = actor.DamageBase;
                    }
                }
                else if (DotRowList[i].TotalSeconds + DotRowList[i].DotSecs <=arow.TotalSeconds)
                {
                    DotRowList[i].DotEndSeconds = DotRowList[i].TotalSeconds + DotRowList[i].DotSecs;
                    DotRowList.Remove(DotRowList[i]);
                }
            }

            return arow;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns>0:player 1:pet 2:npc 3:unknown</returns>
        private int GetPlayerTypeFromName(string name)
        {
            if (Regex.IsMatch(name, "[A-Z]['a-z]+ [A-Z]['a-z]+"))
            {
                return 0;
            }
            else if (Regex.IsMatch(name, "[A-Z]['a-z]+"))
            {
                return 1;
            }
            else if (name.StartsWith("カーバンクル") || 
                name.StartsWith("イフリート・エギ") ||
                name.StartsWith("タイタン・エギ") ||
                name.StartsWith("ガルーダ・エギ") ||
                name.StartsWith("フェアリー・エオス") ||
                name.StartsWith("フェアリー・セレネ"))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void SetDotSpace(FFXIVLogDataSet.AnaylzedRow arow)
        {
            if (!arow.IsEffectOn)
                return ;

            FFXIVLogDataSet.ActionRow action = ds.Action.FindByName(arow.EffectName);
            if (action == null && arow.EffectName == "桜花狂咲")
            {
                action = ds.Action.FindByName("桜華狂咲");
            }

            if (action == null || action.Dot威力 == 0)
            {
                return;//DOT以外は除外
            }

            arow.IsDot = true;
            arow.Dot_Iryoku = action.Dot威力;
            arow.DotSecs = action.効果時間;
            DotRowList.Add(arow);

            if (arow.IsFromNull() || arow.From == "" || arow.From == FF14LogParser.UnknownName)
                return ;
            FFXIVLogDataSet.ActorRow actor = ds.Actor.FindByName(arow.From);
            ////DDダメージを取得
            if (!actor.IsDamageBaseNull())
            {
                arow.DamageBase = actor.DamageBase;
            }
            if (actor.IsNPC || actor.IsOther)
            {
                arow.DotSecs = action.効果時間;//NPC, OTHER はMAXのデフォルトの効果時間
                return ;
            }

           //上書き、効果時間の判定         
            //効果時間内の同じアクション
            FFXIVLogDataSet.AnaylzedRow[] sames = (FFXIVLogDataSet.AnaylzedRow[])ds.Anaylzed.Select(String.Format("ID < {0} and IsEffecton = true and EffectName = '{1}' and To = '{2}' and TotalSeconds > {3} and From = '{4}'",
                arow.ID,
                action.Name,
                arow.To.Replace("'", "''"),
                arow.TotalSeconds - action.効果時間,
                arow.From.Replace("'", "''")));
            if (sames.Length > 0)
            {
                FFXIVLogDataSet.AnaylzedRow[] rows = (FFXIVLogDataSet.AnaylzedRow[])ds.Anaylzed.Select(String.Format("IsKo = false and ToType = 3 and To = '{0}' and EnemyGroupID = {1} and ID >= {2}",
            arow.To, arow.EnemyGroupID,sames[0].ID), "ID");
                FFXIVLogDataSet.AnaylzedRow[] ko_rows = (FFXIVLogDataSet.AnaylzedRow[])ds.Anaylzed.Select(String.Format("IsKo = true and To = '{0}' and EnemyGroupID = {1} and ID > {2}",
                    arow.To, arow.EnemyGroupID, sames[0].ID), "ID");
                arow.DotSpace = sames[0].DotSpace + rows.Length - ko_rows.Length - 1;
                if (arow.DotSpace < 0)
                {
                    arow.DotSpace = 0;
                    sames[sames.Length-1].IsOverride = true;//上書きされた
                    sames[sames.Length-1].DotEndSeconds = arow.TotalSeconds;
                }
            }
            else
            {
                FFXIVLogDataSet.EnemyGroupRow eg = ds.EnemyGroup.FindByName(arow.To);
                if (eg == null)
                {
                    arow.DotSpace = 0;
                    return;
                }
                arow.DotSpace = eg.Count - eg.KOCount - 1;
                if (arow.DotSpace < 0)
                {
                    arow.DotSpace = 0;
                }
                else if (arow.DotSpace > 0)
                {
                }
            }
        }

        private void CloseDot(string to, FFXIVLogDataSet.AnaylzedRow arow, bool all)
        {
            FFXIVLogDataSet.EnemyGroupRow eg = ds.EnemyGroup.FindByName(to);
            if (eg != null)
            {
                FFXIVLogDataSet.AnaylzedRow[] effectrows = (FFXIVLogDataSet.AnaylzedRow[])ds.Anaylzed.Select(String.Format("ID >= {0} and IsEffecton = true and To = '{1}' and DotEndSeconds is null",
                    eg.FirstID, to.Replace("'", "''")), "ID");

                List<string> effects = new List<string>();

                foreach (FFXIVLogDataSet.AnaylzedRow row in effectrows)
                {//DEBUG
                    if (all)
                    {
                        row.DotEndSeconds = arow.TotalSeconds;
                    }
                    else if (!effects.Contains(row.EffectName))
                    {
                        effects.Add(row.EffectName);
                    }
                    else
                    {
                        row.DotEndSeconds = arow.TotalSeconds;
                    }
                }

            }
        }




        /// <summary>
        /// レベルシンクの開始と終了
        /// </summary>
        /// <param name="arow"></param>
        /// <param name="log"></param>
        private void LevelSyncStartEnd(FFXIVLogDataSet.AnaylzedRow arow, FFXIVLog log)
        {
            string _logstring = log.LogBodyReplaceTabCode;

            Regex LevelSyncRegex = new Regex(@":レベル(?<level>\d+)にシンクされました。");
            Match match = LevelSyncRegex.Match(_logstring);
            if (match.Success)
            {
                arow.SyncLevel = Convert.ToInt32(match.Groups["level"].Value, 10);
                arow.IsLevelSyncStart = true;
            }
            Regex LevelSyncEndRegex = new Regex(@":レベルシンクが解除されました。");
            if (LevelSyncEndRegex.Match(_logstring).Success)
            {
                arow.IsLevelSyncEnd = true;                
            }
        }

        /// <summary>
        /// コンテンツの開始終了
        /// </summary>
        /// <param name="arow"></param>
        /// <param name="log"></param>
        private void ContentStartEnd(FFXIVLogDataSet.AnaylzedRow arow, FFXIVLog log)
        {
            string _logstring = log.LogBodyReplaceTabCode;
            Regex contentStartRegex = new Regex(@":「(?<content>.+)」の攻略を開始した。");
            Match match = contentStartRegex.Match(_logstring);
            if (match.Success)
            {
                arow.IsContentStart = true;
                arow.ContentName = match.Groups["content"].Value;

                ds.ContentRegion.AddContentRegionRow(arow.ID, -1, arow.ContentName, true, false);

            }
            Regex contentEndRegex = new Regex(@":[^「]*?「(?<content>.+)」の攻略を終了した。");
            match = contentEndRegex.Match(_logstring);
            if (match.Success)
            {
                arow.IsContentEnd = true;
                arow.ContentName = match.Groups["content"].Value;

               FFXIVLogDataSet.ContentRegionRow[]rows= (FFXIVLogDataSet.ContentRegionRow[]) ds.ContentRegion.Select(String.Format("ContentName = '{0}'",arow.ContentName.Replace("'","''")));
               if (rows.Length > 0)
               {
                   rows[rows.Length - 1].EndLogID = arow.ID;
               }
            }

            //:「(?<content>.+)」の攻略を開始した。
        }

        /// <summary>
        /// 倒した倒された力尽きた
        /// </summary>
        /// <param name="arow"></param>
        /// <param name="log"></param>
        private void KOAnaylyze(FFXIVLogDataSet.AnaylzedRow arow, FFXIVLog log)
        {
            string _logstring = log.LogBodyReplaceTabCode;
            Regex koRegex = new Regex(@":(?<to>.+)は、力尽きた。|:(?<to>.+)は、(?<from>.+)に倒された。|:(?<from>.+)は、(?<to>.+)を倒した。");
            Match match = koRegex.Match(_logstring);
            if (match.Success)
            {
                arow.IsKO = true;
                arow.To = NameConvertTo(log, match.Groups["to"].Value);
                arow.From = NameConvertFrom(log, match.Groups["from"].Value);

                FFXIVLogDataSet.EnemyGroupRow eg = ds.EnemyGroup.FindByName(arow.To);
                if (eg != null && (arow.FLAG_WHO == (int)LOG_CATEGORY_WHO.MYSELF || arow.FLAG_WHO == (int)LOG_CATEGORY_WHO.PTMEMBER))
                {
                    eg.KOCount ++;
                    if (eg.KOCount > eg.Count)
                    {
                        eg.Count = eg.KOCount;
                    }
                }
            }
        }

        private void CureAnalyze(FFXIVLogDataSet.AnaylzedRow arow, FFXIVLog log)
        {
            string _logstring = log.LogBodyReplaceTabCode;
            Regex actionStartRegex = new Regex(@":\s\s⇒\s(|(?<crit>クリティカル！)\s)(?<to>[^！]+)[は](|(?<dodge>[^\d\s]*)\s)(?<num>\d+)(|\((?<bonus>[+-]\d+)\%\))(?<hpmp>\w+)(回復|吸収)");
            Match match = actionStartRegex.Match(_logstring);
            arow.IsCure = true;
            arow.To = NameConvertTo(log,match.Groups["to"].Value);
            arow.From = NameConvertFrom(log,match.Groups["from"].Value);
            arow.ActionName = match.Groups["action"].Value;
            if(match.Groups["num"].Value!="")
            {
                arow.Numeric = Convert.ToInt32(match.Groups["num"].Value, 10);
            }
            if (match.Groups["hpmp"].Value == "ＨＰ")
            {
                arow.IsHP = true;
            }
            else if (match.Groups["hpmp"].Value == "ＴＰ")
            {
                arow.IsTP = true;
            }
            else if (match.Groups["hpmp"].Value == "ＭＰ")
            {
                arow.IsMP = true;
            }
            if (match.Groups["crit"].Value != "")
            {
                arow.IsCritical = true;
            }
            if (arow.From == "")
            {
                if (!log.LogBodyReplaceTabCode.Contains("吸収"))
                {
                    SearchAction(arow, log);
                }
                else
                {
                }
            }
        }


        private void EffectAnalyze(FFXIVLogDataSet.AnaylzedRow arow, FFXIVLog log)
        {
            string _logstring = log.LogBodyReplaceTabCode;
            Regex buffRegex = new Regex(@":  ⇒ (?<to>.+)に「(?<buff>[^」]+)」の(?<on>効果)。|(?<to>[^:\s⇒].+)の「(?<buff>[^」]+)」が(?<off>切れた)。");
            Match match = buffRegex.Match(_logstring);

            if (match.Groups["on"].Value != "")
            {
                arow.IsBuffOn = true;
            }
            else if (match.Groups["off"].Value != "")
            {
                arow.IsDebuffRemove = true;
            }

            arow.To = NameConvertTo(log,match.Groups["to"].Value);
            arow.From = NameConvertFrom(log,match.Groups["from"].Value);
            arow.BuffName = match.Groups["buff"].Value;

            if (arow.From == "")
            {
                SearchAction(arow, log);
            }
            if (arow.IsBuffOn && !arow.IsBuffNameNull())
            {
                FFXIVLogDataSet.ActionRow action = null;
                if (arow.BuffName == "桜花狂咲")
                {
                    action = ds.Action.FindByName("桜華狂咲");
                }
                else
                {
                    action = ds.Action.FindByName(arow.BuffName);
                }
                if (action != null)
                {
                    SetDotSpace(arow);
                }
            }
            if (arow.IsBuffRemove && !arow.IsBuffNameNull())
            {
                FFXIVLogDataSet.ActionRow action = ds.Action.FindByName(arow.BuffName);
                if (action ==null && arow.BuffName == "桜花狂咲")
                {
                    action = ds.Action.FindByName("桜華狂咲");
                }
                if (action != null)
                {
                    CloseDot(arow.To, arow, false);
                }
            }
        }


        private void SearchAction(FFXIVLogDataSet.AnaylzedRow arow, FFXIVLog log)
        {
            List<string> bodyList = new List<string>();
            bodyList.Add(log.LogBodyReplaceTabCode);

            List<int> parentLogtypes = new List<int>(GetParentActionLogTypes(arow));

            if (parentLogtypes.Count == 0)
            {
                return;
            }

            for (int i = ds.Anaylzed.Count - 2; i >= 0; i--)
            {
                FFXIVLogDataSet.AnaylzedRow ActionRow = ds.Anaylzed[i];
                bodyList.Insert(0, ActionRow.Body);
                int minLogType = (int)log.LogType / 4 * 4;

                if(parentLogtypes.Contains(ActionRow.LogType) && (ActionRow.ActionType == 0xAB || ActionRow.ActionType == 0x2B))
                {
                    arow.ActionName = ds.Anaylzed[i].ActionName;
                    arow.From = ds.Anaylzed[i].From;
                    ActionRow.To = arow.To;
                    break;
                }
                else if (ActionRow.TotalSeconds < log.TotalSeconds - 1)//2秒猶予
                {
                    arow.ActionName = FF14LogParser.UnknownName;
                    arow.From = FF14LogParser.UnknownName;
                    break;
                }
            }
        }

        /// <summary>
        /// ログタイプから親となるログタイプを推定
        /// </summary>
        /// <param name="logtype"></param>
        /// <returns></returns>
        private int[] GetParentActionLogTypes(FFXIVLogDataSet.AnaylzedRow row)
        {
            int actiontype = row.ActionType;
            int logtype = row.LogType;

            List<int> res = new List<int>();
            
            //効果が切れたが処理できない
            if (row.IsBuffRemove || row.IsDebuffRemove)
            {
                return res.ToArray();
            }

            if (actiontype == 0xA9 || actiontype == 0x29 || actiontype == 0xAA || actiontype == 0xAD || actiontype == 0x2D || actiontype == 0xAF || actiontype == 0x2F || actiontype == 0xAE || actiontype == 0x2E)
            {//攻撃　攻撃　ミス 回復 回復
                if (logtype >= 0x04 && logtype <= 0x07)
                {
                    res.Add(0x04);//自分の発動
                }
                else if (logtype >= 0x08 && logtype <= 0x0B)
                {
                    res.Add(0x08);//PTの発動
                }
                else if (logtype >= 0x0C && logtype <= 0x0F)
                {
                    res.Add(0x0C);//Allyの発動
                }
                else if (logtype >= 0x10 && logtype <= 0x13)
                {
                    res.Add(0x10);//other pcの発動
                }
                else if (logtype >= 0x14 && logtype <= 0x17)
                {
                    res.Add(0x14);//enemyの発動
                }
                else if (logtype >= 0x18 && logtype <= 0x1B)
                {
                    res.Add(0x18);//npcの発動
                }
            }
            return res.ToArray();
        }


        /// <summary>
        /// ミス解析
        /// </summary>
        /// <param name="arow"></param>
        /// <param name="log"></param>
        private void DodgeAnalyze(FFXIVLogDataSet.AnaylzedRow arow, FFXIVLog log)
        {
            Regex dodgeRegex = new Regex(@":(\s|(?<from>.+)の(?<action>攻撃))\s⇒\s(?<to>.+)にミス|:  ⇒ (?<to>.+)は「(?<action>[^」]+)」をレジストした。|:  ⇒ (?<to>.+)に効果なし。|:  ⇒ (?<to>.+)はレジストした！");

            arow.IsDodge = true;

            string _logstring = log.LogBodyReplaceTabCode;
            Match match = dodgeRegex.Match(_logstring);

            arow.ActionName = match.Groups["action"].Value;
            arow.To =NameConvertTo(log, match.Groups["to"].Value);
            //System.Diagnostics.Debug.Assert(arow.To != "");
            arow.From =NameConvertFrom(log, match.Groups["from"].Value);

            if (arow.From == "")
            {
                SearchAction(arow, log);
            }
        }

        /// <summary>
        /// 実行した中断したの分析
        /// </summary>
        /// <param name="arow"></param>
        /// <param name="log"></param>
        private void ActionStartDoneAnalyze(FFXIVLogDataSet.AnaylzedRow arow, FFXIVLog log)
        {
            Regex ActionRegex = new Regex(@":(ターゲットが範囲外のため、|)(?<from>[^:\s⇒].+)[はの]「(?<action>[^」]+)」");
            string _logstring = log.LogBodyReplaceTabCode;

            Match match = ActionRegex.Match(_logstring);
            arow.ActionName = match.Groups["action"].Value;

            if (log.LogBodyReplaceTabCode.Contains("中断した"))
            {
                arow.IsInterrupted = true;
            }
            else if (log.LogBodyReplaceTabCode.Contains("中断された"))
            {
                arow.IsInterrupted = true;
            }
            else if (log.LogBodyReplaceTabCode.Contains("の構え") || log.LogBodyReplaceTabCode.Contains("を唱えた"))
            {
                arow.IsStarted = true;
            }
            else
            {
                arow.IsDone = true;
            }

            arow.ActionName= match.Groups["action"].Value;
            arow.From = NameConvertFrom(log,match.Groups["from"].Value);
        }

        /// <summary>
        /// ダメージ系のアナライズ
        /// </summary>
        /// <param name="arow"></param>
        /// <param name="log"></param>
        private void HitAnalyze(FFXIVLogDataSet.AnaylzedRow arow, FFXIVLog log)
        {
            //敵視UPの場合
            if (log.LogBodyReplaceTabCode.Contains("敵視をアップ"))
            {
                Regex HateRegex = new Regex(@":  ⇒ (?<to>.+)の敵視をアップ。");
                Match match = HateRegex.Match(log.LogBodyReplaceTabCode.Replace("{022705CF01010103}", "").Replace("{0227050101010103}", ""));// System.Diagnostics.Debug.Write(log.LogBody);
                arow.To = NameConvertTo(log,match.Groups["to"].Value);
                arow.IsDamage = true;
                arow.IsHate = true;
                SearchAction(arow, log);
                return;
            }

            else
            {
                Regex HitRegex = new Regex(@":(\s|(?<from>.+)の(?<action>攻撃))\s⇒\s(|(?<crit>クリティカル！)\s)(?<to>[^！]+)[はに](|(?<dodge>[^\d\s]*)\s)(?<dmg>\d+)(|\((?<bonus>[+-]\d+)\%\))ダメージ");

                arow.IsDamage = true;//ダメージタイプである
                arow.IsHP = true;//HPに影響する

                Match match = HitRegex.Match(log.LogBodyReplaceTabCode.Replace("{022705CF01010103}", "").Replace("{0227050101010103}", "")); //System.Diagnostics.Debug.Write(log.LogBody);
                arow.From = NameConvertFrom(log,match.Groups["from"].Value);
                arow.To = NameConvertTo(log,match.Groups["to"].Value);
                arow.ActionName = match.Groups["action"].Value;
                if (match.Groups["dmg"].Value != "")
                {
                    arow.Numeric = Convert.ToInt32(match.Groups["dmg"].Value,10);
                }
                arow.IsCritical = match.Groups["crit"].Value != "";
                if (match.Groups["bonus"].Value != "")
                {
                    arow.BonusRate = Convert.ToInt32(match.Groups["bonus"].Value);
                }
                if (match.Groups["dodge"].Value.Contains("ブロック"))
                {
                    arow.IsBlock = true;
                }
                if (match.Groups["dodge"].Value.Contains("受け流し"))
                {
                    arow.IsParry = true;
                }
            }
            if (arow.From == "")
            {
                SearchAction(arow, log);
            }

            if (arow.IsFromNull()) arow.From = FF14LogParser.UnknownName;
            if (arow.IsActionNameNull()) arow.ActionName = FF14LogParser.UnknownName;

            //int damage = Convert.ToInt32(match.Groups["damage"].Value,10);
            //int bonus = Convert.ToInt32(match.Groups["bonus"].Value,10);
            //string to = match.Groups["to"].Value;
        }

        /// <summary>
        /// ペット名なら頭に"MY","PT"等をつける 
        /// </summary>
        /// <param name="baseName"></param>
        /// <param name="log"></param>
        /// <returns></returns>
        private string NameConvertFrom( FFXIVLog log,string baseName)
        {

            if(baseName.StartsWith("カーバンクル") ||
                baseName.StartsWith("イフリート・エギ") ||
                baseName.StartsWith("タイタン・エギ") ||
                baseName.StartsWith("ガルーダ・エギ") ||
                baseName.StartsWith("フェアリー・エオス") ||
                baseName.StartsWith("フェアリー・セレネ"))
            {
                if (log.WHO == LOG_CATEGORY_WHO.MYSELF)
                {
                    return baseName+"(MY)";
                }
                else if (log.WHO == LOG_CATEGORY_WHO.PTMEMBER)
                {
                    return baseName+"(PT)";
                }
                else if (log.WHO == LOG_CATEGORY_WHO.ENEMY)
                {
                    return baseName+"(EN)";
                }
                return baseName+"(OTHER)";
            }
            return baseName;
        }

        /// <summary>
        /// ペット名なら頭に"MY","PT"等をつける 
        /// </summary>
        /// <param name="baseName"></param>
        /// <param name="log"></param>
        /// <returns></returns>
        private string NameConvertTo(FFXIVLog log, string baseName)
        {

            if (baseName.StartsWith("カーバンクル") ||
                baseName.StartsWith("イフリート・エギ") ||
                baseName.StartsWith("タイタン・エギ") ||
                baseName.StartsWith("ガルーダ・エギ") ||
                baseName.StartsWith("フェアリー・エオス") ||
                baseName.StartsWith("フェアリー・セレネ"))
            {
                if (log.TO == LOG_CATEGORY_TO.EMPTY_OR_ME)
                {
                    return baseName + "(MY)";
                }
                else if (log.TO ==  LOG_CATEGORY_TO.PTMEMBER)
                {
                    return baseName + "(PT)";
                }
                else if (log.TO ==  LOG_CATEGORY_TO.ENEMY)
                {
                    return baseName + "(EN)";
                }
                return baseName + "(OTHER)";
            }
            return baseName;
        }


        private void SetAction()
        {
            ds.Action.Clear();
            ds.Action.AddActionRow("ファストブレード", "剣術士 ナイト", 150, 0, 0, true);
            ds.Action.AddActionRow("ランパート", "剣術士 ナイト", 0, 0, 20, false);
            ds.Action.AddActionRow("サベッジブレード", "剣術士 格闘士 斧術士 槍術士 弓術士 ナイト 戦士", 100, 0, 0, true);
            ds.Action.AddActionRow("ファイト・オア・フライト", "剣術士 ナイト", 0, 0, 20, false);
            ds.Action.AddActionRow("フラッシュ", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト 戦士", 0, 0, 0, true);
            ds.Action.AddActionRow("コンバレセンス", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト 戦士", 0, 0, 20, false);
            ds.Action.AddActionRow("ライオットソード", "剣術士 ナイト", 100, 0, 0, true);
            ds.Action.AddActionRow("シールドロブ", "剣術士 ナイト", 120, 0, 0, true);
            ds.Action.AddActionRow("シールドバッシュ", "剣術士 ナイト", 110, 0, 0, true);
            ds.Action.AddActionRow("挑発", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト 戦士", 0, 0, 0, true);
            ds.Action.AddActionRow("レイジ・オブ・ハルオーネ", "剣術士 ナイト", 100, 0, 0, true);
            ds.Action.AddActionRow("忠義の剣", "ナイト", 50, 0, 0, false);
            ds.Action.AddActionRow("シールドスワイプ", "剣術士 ナイト", 170, 0, 6, true);
            ds.Action.AddActionRow("アウェアネス", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト 戦士", 0, 0, 15, true);
            ds.Action.AddActionRow("かばう", "ナイト", 0, 0, 0, false);
            ds.Action.AddActionRow("センチネル", "剣術士 ナイト", 0, 0, 10, false);
            ds.Action.AddActionRow("忠義の盾", "ナイト", 0, 0, 0, false);
            ds.Action.AddActionRow("鋼の意志", "剣術士 ナイト", 0, 0, 10, false);
            ds.Action.AddActionRow("スピリッツウィズイン", "ナイト", 300, 0, 0, true);
            ds.Action.AddActionRow("ブルワーク", "剣術士 ナイト", 0, 0, 15, false);
            ds.Action.AddActionRow("サークル・オブ・ドゥーム", "剣術士 ナイト", 100, 30, 15, true);
            ds.Action.AddActionRow("インビンシブル", "ナイト", 0, 0, 10, false);

            ds.Action.AddActionRow("連撃", "格闘士 モンク", 130, 0, 0, true);
            ds.Action.AddActionRow("正拳突き", "格闘士 モンク", 150, 0, 0, true);
            ds.Action.AddActionRow("フェザーステップ", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 モンク 戦士", 0, 0, 0, false);
            ds.Action.AddActionRow("崩拳", "格闘士 モンク", 140, 0, 0, true);
            ds.Action.AddActionRow("内丹", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 モンク 戦士 竜騎士", 0, 0, 0, false);
            ds.Action.AddActionRow("カウンター", "剣術士 格闘士 斧術士 槍術士 弓術士 モンク 戦士 竜騎士", 170, 0, 0, true);
            ds.Action.AddActionRow("発剄", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 モンク 戦士 竜騎士", 0, 0, 0, false);
            ds.Action.AddActionRow("秘孔拳", "格闘士 モンク", 20, 25, 30, true);
            ds.Action.AddActionRow("双掌打", "格闘士 モンク", 100, 0, 0, true);
            ds.Action.AddActionRow("金剛の構え", "格闘士 モンク", 0, 0, 0, false);
            ds.Action.AddActionRow("壊神衝", "格闘士 モンク", 50, 0, 0, true);
            ds.Action.AddActionRow("地烈斬", "モンク", 130, 0, 0, true);
            ds.Action.AddActionRow("破砕拳", "格闘士 モンク", 0, 40, 12, true);
            ds.Action.AddActionRow("疾風の構え", "格闘士 モンク", 0, 0, 0, false);
            ds.Action.AddActionRow("羅刹衝", "モンク", 100, 0, 0, true);
            ds.Action.AddActionRow("鉄山靠", "格闘士 モンク", 150, 0, 0, true);
            ds.Action.AddActionRow("紅蓮の構え", "モンク", 0, 0, 0, false);
            ds.Action.AddActionRow("マントラ", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 モンク 戦士 竜騎士", 0, 0, 0, false);
            ds.Action.AddActionRow("短勁", "モンク", 80, 0, 0, true);
            ds.Action.AddActionRow("空鳴拳", "格闘士 モンク", 170, 0, 0, true);
            ds.Action.AddActionRow("踏鳴", "格闘士 モンク", 0, 0, 0, false);
            ds.Action.AddActionRow("双竜脚", "モンク", 100, 0, 0, true);

            ds.Action.AddActionRow("ヘヴィスウィング", "斧術士 戦士", 150, 0, 0, true);
            ds.Action.AddActionRow("フォーサイト", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト モンク 戦士 竜騎士", 0, 0, 20, false);
            ds.Action.AddActionRow("スカルサンダー", "斧術士 戦士", 100, 0, 0, true);
            ds.Action.AddActionRow("フラクチャー", "剣術士 格闘士 斧術士 槍術士 弓術士 ナイト モンク 戦士 竜騎士", 100, 20, 30, true);
            ds.Action.AddActionRow("ブラッドバス", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト モンク 戦士 竜騎士", 0, 0, 0, false);
            ds.Action.AddActionRow("ブルータルスウィング", "斧術士 戦士", 100, 0, 0, true);
            ds.Action.AddActionRow("オーバーパワー", "斧術士 戦士", 120, 0, 0, true);
            ds.Action.AddActionRow("トマホーク", "斧術士 戦士", 130, 0, 0, true);
            ds.Action.AddActionRow("メイム", "斧術士 戦士", 100, 0, 0, true);
            ds.Action.AddActionRow("バーサク", "斧術士 戦士", 0, 0, 0, false);
            ds.Action.AddActionRow("マーシーストローク", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト モンク 戦士 竜騎士", 200, 0, 0, true);
            ds.Action.AddActionRow("ディフェンダー", "戦士", 0, 0, 0, false);
            ds.Action.AddActionRow("ボーラアクス", "斧術士 戦士", 100, 0, 0, true);
            ds.Action.AddActionRow("スリル・オブ・バトル", "斧術士 戦士", 0, 0, 0, false);
            ds.Action.AddActionRow("原初の魂", "戦士", 300, 0, 0, true);
            ds.Action.AddActionRow("シュトルムヴィント", "斧術士 戦士", 100, 0, 0, true);
            ds.Action.AddActionRow("アンチェインド", "戦士", 0, 0, 0, false);
            ds.Action.AddActionRow("ホルムギャング", "斧術士 戦士", 0, 0, 0, true);
            ds.Action.AddActionRow("スチールサイクロン", "戦士", 200, 0, 0, true);
            ds.Action.AddActionRow("ヴェンジェンス", "斧術士 戦士", 0, 50, 0, false);
            ds.Action.AddActionRow("シュトルムブレハ", "斧術士 戦士", 100, 0, 0, true);
            ds.Action.AddActionRow("ウォークライ", "戦士", 0, 0, 0, false);

            ds.Action.AddActionRow("トゥルースラスト", "槍術士 竜騎士", 150, 0, 0, true);
            ds.Action.AddActionRow("フェイント", "剣術士 格闘士 斧術士 槍術士 弓術士 モンク 竜騎士 吟遊詩人", 120, 0, 0, true);
            ds.Action.AddActionRow("ボーパルスラスト", "槍術士 竜騎士", 100, 0, 0, true);
            ds.Action.AddActionRow("キーンフラーリ", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 モンク 竜騎士 吟遊詩人", 0, 0, 0, false);
            ds.Action.AddActionRow("インパルスドライヴ", "剣術士 格闘士 斧術士 槍術士 モンク 竜騎士", 100, 0, 0, true);
            ds.Action.AddActionRow("足払い", "槍術士 竜騎士", 130, 0, 0, true);
            ds.Action.AddActionRow("ヘヴィスラスト", "槍術士 竜騎士", 100, 0, 0, true);
            ds.Action.AddActionRow("ピアシングタロン", "槍術士 竜騎士", 120, 0, 0, true);
            ds.Action.AddActionRow("ライフサージ", "槍術士 竜騎士", 0, 0, 0, false);
            ds.Action.AddActionRow("気合", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 モンク 竜騎士 吟遊詩人", 0, 0, 0, false);
            ds.Action.AddActionRow("フルスラスト", "槍術士 竜騎士", 100, 0, 0, true);
            ds.Action.AddActionRow("ジャンプ", "竜騎士", 200, 0, 0, true);
            ds.Action.AddActionRow("二段突き", "", 170, 20, 18, true);
            ds.Action.AddActionRow("捨身", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 モンク 竜騎士 吟遊詩人", 0, 0, 0, false);
            ds.Action.AddActionRow("イルーシブジャンプ", "竜騎士", 0, 0, 0, false);
            ds.Action.AddActionRow("ディセムボウル", "槍術士 竜騎士", 100, 0, 0, true);
            ds.Action.AddActionRow("スパインダイブ", "竜騎士", 170, 0, 0, true);
            ds.Action.AddActionRow("ドゥームスパイク", "槍術士 竜騎士", 160, 0, 0, true);
            ds.Action.AddActionRow("竜槍", "竜騎士", 0, 0, 0, false);
            ds.Action.AddActionRow("リング・オブ・ソーン", "槍術士 竜騎士", 100, 0, 0, true);
            ds.Action.AddActionRow("桜華狂咲", "槍術士 竜騎士", 100, 20, 30, true);
            ds.Action.AddActionRow("ドラゴンダイブ", "竜騎士", 250, 0, 0, true);

            ds.Action.AddActionRow("ヘヴィショット", "弓術士 吟遊詩人", 150, 0, 0, true);
            ds.Action.AddActionRow("ストレートショット", "剣術士 格闘士 斧術士 槍術士 弓術士 吟遊詩人", 140, 0, 0, true);
            ds.Action.AddActionRow("猛者の撃", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 吟遊詩人 黒魔道士 召喚士", 0, 0, 0, false);
            ds.Action.AddActionRow("ベノムバイト", "剣術士 格闘士 斧術士 槍術士 弓術士 吟遊詩人", 100, 35, 18, true);
            ds.Action.AddActionRow("ミザリーエンド", "弓術士 吟遊詩人", 190, 0, 0, true);
            ds.Action.AddActionRow("影縫い", "弓術士 吟遊詩人", 0, 0, 0, true);
            ds.Action.AddActionRow("ブラッドレッター", "弓術士 吟遊詩人", 150, 0, 0, true);
            ds.Action.AddActionRow("リペリングショット", "弓術士 吟遊詩人", 80, 0, 0, true);
            ds.Action.AddActionRow("クイックノック", "弓術士 吟遊詩人", 110, 0, 0, true);
            ds.Action.AddActionRow("スウィフトソング", "弓術士 吟遊詩人", 0, 0, 0, false);
            ds.Action.AddActionRow("ホークアイ", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 吟遊詩人 黒魔道士 召喚士", 0, 0, 0, false);
            ds.Action.AddActionRow("賢人のバラード", "吟遊詩人", 0, 0, 0, false);
            ds.Action.AddActionRow("ウィンドバイト", "弓術士 吟遊詩人", 60, 40, 18, true);
            ds.Action.AddActionRow("静者の撃", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 吟遊詩人 黒魔道士 召喚士", 0, 0, 0, false);
            ds.Action.AddActionRow("魔人のレクイエム", "吟遊詩人", 0, 0, 0, false);
            ds.Action.AddActionRow("乱れ撃ち", "弓術士 吟遊詩人", 0, 0, 0, false);
            ds.Action.AddActionRow("軍神のパイオン", "吟遊詩人", 0, 0, 0, false);
            ds.Action.AddActionRow("ブラントアロー", "弓術士 吟遊詩人", 50, 0, 0, true);
            ds.Action.AddActionRow("レイン・オブ・デス", "吟遊詩人", 100, 0, 0, true);
            ds.Action.AddActionRow("フレイミングアロー", "弓術士 吟遊詩人", 0, 35, 30, true);
            ds.Action.AddActionRow("ワイドボレー", "弓術士 吟遊詩人", 110, 0, 0, true);
            ds.Action.AddActionRow("バトルボイス", "吟遊詩人", 0, 0, 0, false);

            ds.Action.AddActionRow("ストーン", "幻術士 白魔道士", 140, 0, 0, true);
            ds.Action.AddActionRow("ケアル", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト 吟遊詩人 白魔道士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("エアロ", "幻術士 呪術士 巴術士 白魔道士 学者", 50, 25, 18, true);
            ds.Action.AddActionRow("クルセードスタンス", "幻術士 白魔道士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("プロテス", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト 吟遊詩人 白魔道士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("メディカ", "幻術士 白魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("レイズ", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト 吟遊詩人 白魔道士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("アクアオーラ", "幻術士 白魔道士", 150, 0, 0, true);
            ds.Action.AddActionRow("エスナ", "幻術士 白魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("ストンラ", "幻術士 白魔道士", 170, 0, 0, true);
            ds.Action.AddActionRow("リポーズ", "幻術士 白魔道士", 0, 0, 0, true);
            ds.Action.AddActionRow("神速魔", "白魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("ケアルラ", "幻術士 白魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("ストンスキン", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 ナイト 吟遊詩人 白魔道士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("リジェネ", "白魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("女神の加護", "幻術士 白魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("ディヴァインシール", "白魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("ケアルガ", "幻術士 白魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("ホーリー", "白魔道士", 240, 0, 0, true);
            ds.Action.AddActionRow("エアロラ", "幻術士 白魔道士", 50, 40, 12, true);
            ds.Action.AddActionRow("メディカラ", "幻術士 白魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("ベネディクション", "白魔道士", 0, 0, 0, false);

            ds.Action.AddActionRow("ブリザド", "呪術士 黒魔道士", 150, 0, 0, true);
            ds.Action.AddActionRow("ファイア", "呪術士 黒魔道士", 150, 0, 0, true);
            ds.Action.AddActionRow("トランス", "呪術士 黒魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("サンダー", "幻術士 呪術士 巴術士 白魔道士 黒魔道士 召喚士 学者", 30, 35, 18, true);
            ds.Action.AddActionRow("堅実魔", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 白魔道士 黒魔道士 召喚士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("スリプル", "呪術士 黒魔道士", 0, 0, 0, true);
            ds.Action.AddActionRow("ブリザラ", "呪術士 黒魔道士", 100, 0, 0, true);
            ds.Action.AddActionRow("コラプス", "呪術士 黒魔道士", 100, 0, 0, true);
            ds.Action.AddActionRow("ファイラ", "呪術士 黒魔道士", 100, 0, 0, true);
            ds.Action.AddActionRow("サンダラ", "呪術士 黒魔道士", 50, 35, 21, true);
            ds.Action.AddActionRow("迅速魔", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 白魔道士 黒魔道士 召喚士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("コンバート", "黒魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("マバリア", "呪術士 黒魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("ファイガ", "呪術士 黒魔道士", 220, 0, 0, true);
            ds.Action.AddActionRow("フリーズ", "黒魔道士", 20, 0, 0, true);
            ds.Action.AddActionRow("ブリザガ", "呪術士 黒魔道士", 220, 0, 0, true);
            ds.Action.AddActionRow("アポカタスタシス", "黒魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("レサージー", "呪術士 黒魔道士", 0, 0, 0, true);
            ds.Action.AddActionRow("ウォール", "黒魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("サンダガ", "呪術士 黒魔道士", 60, 35, 24, true);
            ds.Action.AddActionRow("エーテリアルステップ", "呪術士 黒魔道士", 0, 0, 0, false);
            ds.Action.AddActionRow("フレア", "黒魔道士", 260, 0, 0, true);

            ds.Action.AddActionRow("ルイン", "幻術士 呪術士 巴術士 白魔道士 黒魔道士 召喚士 学者", 80, 0, 0, true);
            ds.Action.AddActionRow("バイオ", "巴術士 召喚士 学者", 0, 40, 18, true);
            ds.Action.AddActionRow("サモン", "巴術士 召喚士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("フィジク", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 白魔道士 黒魔道士 召喚士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("エーテルフロー", "巴術士 召喚士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("エナジードレイン", "巴術士 召喚士 学者", 150, 0, 0, true);
            ds.Action.AddActionRow("ミアズマ", "巴術士 召喚士 学者", 20, 35, 24, true);
            ds.Action.AddActionRow("ウイルス", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 白魔道士 黒魔道士 召喚士 学者", 0, 0, 0, true);
            ds.Action.AddActionRow("サステイン", "巴術士 召喚士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("リザレク", "巴術士 召喚士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("バイオラ", "巴術士 召喚士 学者", 0, 35, 30, true);
            ds.Action.AddActionRow("アイ・フォー・アイ", "剣術士 格闘士 斧術士 槍術士 弓術士 幻術士 呪術士 巴術士 白魔道士 黒魔道士 召喚士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("ルインラ", "巴術士 召喚士 学者", 80, 0, 0, true);
            ds.Action.AddActionRow("ラウズ", "巴術士 召喚士 学者", 0, 0, 0, false);
            ds.Action.AddActionRow("ミアズラ", "巴術士 召喚士 学者", 20, 10, 0, true);
            ds.Action.AddActionRow("シャドウフレア", "巴術士 召喚士 学者", 0, 25, 30, true);
        }
    }
}
