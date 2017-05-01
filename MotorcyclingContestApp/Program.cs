using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MotorcyclingContestApp.Forms;

namespace MotorcyclingContestApp
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
            var mainForm = DependencyFactory.Resolve<LoginForm>();
            Application.Run(mainForm);
        }
    }
}
