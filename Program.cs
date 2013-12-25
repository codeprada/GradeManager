using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Grade_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Threadpool to wait on welcome screen to finish running its checks
            WaitHandle[] wait_handles = new WaitHandle[] { new AutoResetEvent(false) };
            ThreadPool.QueueUserWorkItem(fWelcomeScreen.Run, wait_handles[0]);
            WaitHandle.WaitAll(wait_handles);
                        
            Application.Run(new fMainForm());
        }
    }
}
