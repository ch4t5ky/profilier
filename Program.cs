using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profiler
{
    static class Program
    {
        public static int MAX_ATTEMPT = 4;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RegistryKey software = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey applicationKey = software.OpenSubKey("Profiler", true);
            if (applicationKey == null)
            {
                applicationKey = software.CreateSubKey("Profiler");
                applicationKey.SetValue("time", DateTime.Now.AddMinutes(3).ToString());
                applicationKey.SetValue("attempt", "1");
            }

            applicationKey = software.OpenSubKey("Profiler", true);
            string time_limit = applicationKey.GetValue("time").ToString();
            int attempt_limit = int.Parse(applicationKey.GetValue("attempt").ToString());


            if (DateTime.Compare(DateTime.Now, DateTime.Parse(time_limit)) >= 0 || attempt_limit >= MAX_ATTEMPT)
            {
                Application.Run(new Expire());
            } else
            {
                applicationKey.DeleteValue("attempt");
                attempt_limit++;
                applicationKey.SetValue("attempt", (attempt_limit).ToString());
                applicationKey.Close();
                software.Close();
                MessageBox.Show("Осталось: " + (MAX_ATTEMPT - attempt_limit).ToString() + ". \n" + "Дата закрытия: " + time_limit);
                Application.Run(new Form1());
                
            }
            
            
        }
    }
}
