using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechArmy
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        
        {
            Program prog = new Program();
            Thread thread1 = new Thread(new ThreadStart(prog.timedBackup));
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            thread1.Start();
            Application.Run(new Splash_Screen());

        }
        public void timedBackup()
        {
            var backupTime = new DateTime(9999, 10, 20,  20, 0, 0);
            var time = DateTime.Now;
            bool e = true;
            
            while(e)
            {
                if (time.TimeOfDay >= backupTime.TimeOfDay)
                {
                    //INSERT BACKUP OBJECT HERE
                    BackupHandler backup= new BackupHandler(time);
                    Task.Run(() => backup.FileUploadAsync()).Wait();

                    //Do not modify
                    e = false;
                }
                else
                {
                    //Sleep thread for 10 minutes
                    Thread.Sleep(600000);
                }
            }

        }
    }
}
