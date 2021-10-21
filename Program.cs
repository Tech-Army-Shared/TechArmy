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
            

            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            thread1.Start();
            Application.Run(new Splash_Screen());
   
        }
        public void timedBackup()
        {
            
        }
    }
}
