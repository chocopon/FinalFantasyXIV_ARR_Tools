using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FF14FastReport
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FastRepMainForm());
            Application.Run(new CompactForm());
        }
    }
}
