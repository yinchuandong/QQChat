﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace QQChat
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// 
        public static UiForm.MainForm mWin = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UiForm.LoginForm());
        }
    }
}
