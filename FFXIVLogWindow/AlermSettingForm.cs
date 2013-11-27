using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFXIVLogWindow
{
    /// <summary>
    /// アラーム設定ツールウィンドウ
    /// </summary>
    public partial class AlarmSettingForm : Form
    {
        public bool IsExUserChat
        {
            get
            {
                return ExUserchatBox.Checked;
            }
            set
            {
                ExUserchatBox.Checked = value;
            }
        }

        public bool IsFC
        {
            get
            {
                return FCBox.Checked;
            }
            set
            {
                FCBox.Checked = value;
            }
        }

        public bool IsSay
        {
            get
            {
                return SayBox.Checked;
            }
            set
            {
                SayBox.Checked=value;
            }
        }

        public bool IsShout
        {
            get
            {
                return ShoutBox.Checked;
            }
            set
            {
               ShoutBox.Checked=value;
            }
        }

        public bool IsParty
        {
            get
            {
                return PartyBox.Checked;
            }
            set
            {
                PartyBox.Checked=value;
            }
        }
        public bool IsYell
        {
            get
            {
                return YellBox.Checked;
            }
            set
            {
                YellBox.Checked=value;
            }
        }

        public bool IsEmote
        {
            get
            {
                return EmoteBox.Checked;
            }
            set
            {
               EmoteBox.Checked=value;
            }
        }

        public bool IsLS1
        {
            get
            {
                return LS1Box.Checked;
            }
            set
            {
                LS1Box.Checked=value;
            }
        }

        public bool IsLS2
        {
            get
            {
                return LS2Box.Checked;
            }
            set
            {
                LS2Box.Checked=value;
            }
        }
        public bool IsLS3
        {
            get
            {
                return LS3Box.Checked;
            }
            set
            {
                LS3Box.Checked=value;
            }
        }
        public bool IsLS4
        {
            get
            {
                return LS4Box.Checked;
            }
            set
            {
                LS4Box.Checked=value;
            }
        }
        public bool IsLS5
        {
            get
            {
                return LS5Box.Checked;
            }
            set
            {
                LS5Box.Checked=value;
            }
        }
        public bool IsLS6
        {
            get
            {
                return LS6Box.Checked;
            }
            set
            {
                LS6Box.Checked=value;
            }
        }
        public bool IsLS7
        {
            get
            {
                return LS7Box.Checked;
            }
            set
            {
                LS7Box.Checked=value;
            }
        }
        public bool IsLS8
        {
            get
            {
                return LS8Box.Checked;
            }
            set
            {
                LS8Box.Checked = value;
            }
        }

        public string AlarmName
        {
            get
            {
                return AlarmNameBox.Text;
            }
            set
            {
                AlarmNameBox.Text=value;
            }
        }

        public string FilterText
        {
            get
            {
                return FilterTextBox.Text;
            }
            set
            {
                FilterTextBox.Text = value;
            }

        }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AlarmSettingForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public void LoadAlarmSettings(AlarmSetting settings)
        {
            AlarmName = settings.Name;
            FilterText = settings.FilterString;
            IsExUserChat = settings.ExUserChat;
            IsFC = settings.FC;
            IsSay = settings.Say;
            IsShout = settings.Shout;
            IsParty = settings.Party;
            IsYell = settings.Yell;
            IsEmote = settings.Emote;
            IsLS1 = settings.LS1;
            IsLS2 = settings.LS2;
            IsLS3 = settings.LS3;
            IsLS4 = settings.LS4;
            IsLS5 = settings.LS5;
            IsLS6 = settings.LS6;
            IsLS7 = settings.LS7;
            IsLS8 = settings.LS8;
        }

        public AlarmSetting GetAlarmSettings()
        {
            AlarmSetting settings = new AlarmSetting();
            settings.Name = AlarmName;
            settings.FilterString = FilterText;
            settings.ExUserChat = IsExUserChat;
            settings.FC = IsFC;
            settings.Say = IsSay;
            settings.Shout = IsShout;
            settings.Party = IsParty;
            settings.Yell = IsYell;
            settings.Emote = IsEmote;
            settings.LS1 = IsLS1;
            settings.LS2 = IsLS2;
            settings.LS3 = IsLS3;
            settings.LS4 = IsLS4;
            settings.LS5 = IsLS5;
            settings.LS6 = IsLS6;
            settings.LS7 = IsLS7;
            settings.LS8 = IsLS8;
            return settings;
        }
    }
}
