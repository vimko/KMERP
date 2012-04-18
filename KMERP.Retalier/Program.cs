using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

using Qios.DevSuite.Components;
using Qios.DevSuite.Components.Ribbon;

namespace KMERP.Retalier
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();



            QGlobalFont.Instance.InheritFromWindows = false;
            try
            {
                FontFamily tmp_oFamily = new FontFamily("Segoe UI");
                QGlobalFont.Instance.Font = new Font(tmp_oFamily, 9.0F);
            }
            catch
            {
                QGlobalFont.Instance.Font = new Font("宋体", 8.25F);
            }

            
            QColorScheme.Global.InheritCurrentThemeFromWindows = false;
            QColorScheme.Global.CurrentTheme = "LunaBlue";

            

            //Application.Run(new UI.UserLoginForm());

            try
            {
                MainForm form = new MainForm();

                Application.Run(form);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
