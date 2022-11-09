using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Model_Estimation_Software
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(File.Exists(Application.StartupPath + "\\SettingData.txt") == false)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\SettingData.txt");
                sw.WriteLine("1.00");
                sw.WriteLine("0.50");
                sw.WriteLine("0.50");
                sw.WriteLine("0.50");
                sw.Close();
            }
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
