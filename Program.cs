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
            
            //This is a temporary measure to ensure that the program does not need to be manually killed
            //in task manager
            thread1.IsBackground = false;

            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            thread1.Start();
            Application.Run(new Splash_Screen());

        }
        public void timedBackup()
        {
            var backupTime = new DateTime(9999, 10, 20,  20, 0, 0);
            DateTime time;
            bool e = false;
            
            // e = false if it hasn't backed up yet
            // e = true if it has backed up

            while(true)
            {
                time = DateTime.Now;

                //This checks if the current time is later than the specified time AND if a backup has occurred

                if (time.TimeOfDay > backupTime.TimeOfDay && e == false)
                {
                    //If it's later than 20:00 and a backup didn't occur
                    
                    BackupHandler backup= new BackupHandler(time);
                    Task.Run(() => backup.FileUploadAsync()).Wait();

                    e = true;
                }
                else if(time.TimeOfDay > backupTime.TimeOfDay && e == true)
                {
                    //If it's later than 20:00 and a backup did occur
                    Thread.Sleep(600000);
                }
                else if (time.TimeOfDay < backupTime.TimeOfDay && e == false)
                {
                    //If it's earlier than 20:00 and a backup didn't occur
                    Thread.Sleep(600000);
                }
                else if(time.TimeOfDay < backupTime.TimeOfDay && e == true)
                {
                    //If it's earlier than 20:00 and a backup did occur (indicating a new day)
                    e = false;
                }

            }
        }
    }
}
