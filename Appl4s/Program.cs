using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Appl4s
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            _initialCEF();
            
            Application.ApplicationExit += applicationOnApplicationExit;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
            
        }

        private static void applicationOnApplicationExit(object sender, EventArgs e)
        {
            Cef.Shutdown();
        }

        #region 初始化CEF
        private static void _initialCEF()
        {
            Cef.Initialize(new CefSettings()
            {
                Locale = "zh-CN",
                AcceptLanguageList = "zh-CN"
            });
        }
        #endregion
    }
}
