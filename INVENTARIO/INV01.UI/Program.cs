using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using INV01.UI.Formularios;
using INV01.DO.DATA;
using INV01.UI.Clases;

namespace INV01.UI
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
            Application.Run(new formMain());

            //if (false)
            //{
            //    Application.Run(new formMain());
            //}
            //else
            //{
            //    Application.Run(new FormLogin());
            //}

            
        }
    }
}
