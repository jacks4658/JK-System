
using BaseFirebase;
using FlatLoginWatermark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    static class Program

    {
        /// </JK System>
        ///ENTRADA PRINCIPAL DA APLICAÇãO
        /// </JK System>
        [STAThread]
        static void Main()

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenuPrincipal());
        }
    }
}
