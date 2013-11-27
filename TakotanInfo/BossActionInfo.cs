using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFXIV_Tools;

namespace Infoman
{
    public class BossActionInfo
    {
        public string BossName;


    }


    public class SinTitan
    {
        public string[] CurrentActions
        {
            get
            {
                if (PhaseNumber == 1)
                    return phase1_actions;
                if (PhaseNumber == 2)
                    return phase2_actions;
                if (PhaseNumber == 3)
                    return phase3_actions;
                if (PhaseNumber == 4)
                    return phase4_actions;
                if (PhaseNumber == 5)
                    return phase5_actions;
                return phase1_actions;
            }
        }
        public string preAction;

        int _actionIndex;

        public int actionIndex
        {
            get
            {
                return _actionIndex;
            }
            set
            {
                if (actionIndex != value)
                {
                    preAction = NextAction;
                    _actionIndex = value;
                }
            }
        }

        public string NextAction{
            get{
                if (actionIndex < CurrentActions.Length)
                {
                    return CurrentActions[actionIndex];
                }
                else
                {
                    return "";
                }
            }
        }
        public string NextNextAction
        {
            get
            {
                if (actionIndex == CurrentActions.Length-1)
                {
                    return CurrentActions[0];
                }
                return CurrentActions[actionIndex + 1];
            }
        }
        public int PhaseNumber
        {
            get;
            set;
        }

        public string[] GetActions(int fase)
        {
            return null;
        }

        public SinTitan()
        {
            PhaseNumber = 1;
        }

        public void PhaseUpdate(string LogBody,int totalseconds)
        {
            //フェーズ選定初期化　リセット忘れ対策
            if (LogBody.Contains("横暴なるヒトの子よ"))
            {
                actionIndex = 0;
                PhaseNumber = 1;
                return;
            }
            //途中でキャンセルおしちゃった対策
            if (LogBody.Contains("「岩神の心石」が切れた"))
            {
                actionIndex = 0;
                PhaseNumber = 5;
                preAction = "大地の怒り";
                return;
            }

            if (PhaseNumber == 1)
            {
                if (LogBody.Contains("「ジオクラッシュ」の構え"))
                {
                    actionIndex = 0;
                    PhaseNumber = 2;
                    preAction = "ジオクラッシュ";
                }
                else if (LogBody.Contains("「ランドスライド」"))
                {
                    actionIndex = 1;
                }
                else if (LogBody.Contains("「激震」"))
                {
                    actionIndex = 0;
                }
            }
            else if (PhaseNumber == 2)
            {//"大地の重み", "ランドスライド", "激震" 
                if (LogBody .Contains("「ジオクラッシュ」の構え"))
                {
                    actionIndex = 0;
                    PhaseNumber = 3;
                    preAction = "ジオクラッシュ";
                }
                else if (LogBody .Contains("「大地の重み」"))
                {
                    actionIndex = 1;
                }
                else if (LogBody .Contains("「ランドスライド」"))
                {
                    actionIndex = 2;
                }
                else if (LogBody .Contains("「激震」"))
                {
                    actionIndex = 0;
                }
            }
            else if (PhaseNumber == 3)
            {//  "ランドスライド", "大地の重み", "ボムボルダー", "ランドスライド", "大地の重み", "グラナイト・ジェイル", "激震"
                if (LogBody .Contains("「ジオクラッシュ」の構え"))
                {
                    actionIndex = 0;
                    PhaseNumber = 4;
                    preAction = "ジオクラッシュ";
                }
                else if (LogBody.Contains("「ランドスライド」"))
                {
                    if (actionIndex == 3)
                    {
                        actionIndex = 4;
                    }
                    else if(actionIndex ==0)
                    {
                        actionIndex = 1;
                    }
                }
                else if (LogBody .Contains("「大地の重み」"))
                {
                    if (actionIndex == 1)
                    {
                        actionIndex = 2;
                    }
                    else if(actionIndex ==4)
                    {
                        actionIndex = 5;
                    }
                }
                else if (LogBody.Contains("ボムボルダーを"))
                {
                    actionIndex = 3;
                }
                else if (LogBody.Contains("「グラナイト・ジェイル」"))
                {
                    actionIndex = 6;
                }
                else if (LogBody.Contains("「激震」"))
                {
                    actionIndex = 0;
                }
            }
            else if (PhaseNumber == 4)
            {//  "グラナイト・ジェイル", "ランドスライド", "大地の重み", "激震", "グラナイト・ジェイル", "ランドスライド", "大地の重み","大地の怒り","マウンテンバスター"};
                if (LogBody .Contains("「岩神の心石」が切れた"))
                {
                    actionIndex = 0;
                    PhaseNumber = 5;
                    preAction = "大地の怒り";

                }
                else if (LogBody .Contains("「グラナイト・ジェイル」"))
                {
                    if (actionIndex == 0)
                    {
                        actionIndex = 1;
                    }
                    else if(actionIndex ==4)
                    {
                        actionIndex = 5;
                    }

                }
                else if (LogBody .Contains("「ランドスライド」"))
                {
                    if (actionIndex == 1)
                    {
                        actionIndex = 2;
                    }
                    else if(actionIndex == 5)
                    {
                        actionIndex = 6;
                    }
                }
                else if (LogBody .Contains("「大地の重み」"))
                {
                    if (actionIndex == 6)
                    {
                        actionIndex = 7;
                    }
                    else if(actionIndex ==2)
                    {
                        actionIndex = 3;
                    }

                }
                else if (LogBody .Contains("「激震」"))
                {
                    actionIndex = 4;
                }
            }
            else if (PhaseNumber == 5)
            {//マウンテンバスター", "激震", "大地の重み", "ボムボルダー", "ランドスライド", "マウンテンバスター", "大地の重み", "グラナイト・ジェイル", "ランドスライド" 
                if (LogBody .Contains("「マウンテンバスター」"))
                {
                    if (actionIndex == 0)
                    {
                        actionIndex = 1;
                    }
                    else if(actionIndex ==5)
                    {
                        actionIndex = 6;
                    }
                }
                else if (LogBody .Contains("「激震」"))
                {
                    actionIndex = 2;
                }
                else if (LogBody .Contains("「大地の重み」"))
                {
                    if (actionIndex == 2)
                    {
                        actionIndex = 3;
                    }
                    else if(actionIndex ==6)
                    {
                        actionIndex = 7;
                    }
                }
                else if (LogBody.Contains("ボムボルダーを"))
                {
                    actionIndex = 4;
                }
                else if (LogBody .Contains("「ランドスライド」"))
                {
                    if (actionIndex == 4)
                    {
                        actionIndex = 5;
                    }
                    else if (actionIndex == 8)
                    {
                        actionIndex = 0;
                    }
                }
                else if (LogBody .Contains("「グラナイト・ジェイル」"))
                {
                    actionIndex = 8;
                }

            }

        }
        

        static string[] phase1_actions = new string[] { "ランドスライド", "激震" };
        static string[] phase2_actions = new string[] { "大地の重み", "ランドスライド", "激震" };
        static string[] phase3_actions = new string[] { "ランドスライド", "大地の重み", "ボムボルダー", "ランドスライド", "大地の重み", "グラナイト・ジェイル", "激震" };
        static string[] phase4_actions = new string[] { "グラナイト・ジェイル", "ランドスライド", "大地の重み", "激震", "グラナイト・ジェイル", "ランドスライド", "大地の重み","大地の怒り","マウンテンバスター"};
        static string[] phase5_actions = new string[] { "マウンテンバスター", "激震", "大地の重み", "ボムボルダー", "ランドスライド", "マウンテンバスター", "大地の重み", "グラナイト・ジェイル", "ランドスライド" };

    }
}
