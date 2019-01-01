using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OPENSOURCEHOMEACCOUNTING
{
    static class main
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new mainView());
            Controller con = new Controller();
            con.run();
        }
    }
}
