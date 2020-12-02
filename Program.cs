using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClientWfTempConversion.ReferenceTempConversion;

namespace WcfClientWfTempConversion
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceConversionClient client = new ServiceConversionClient("BasicHttpBinding_IServiceConversion");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(client));
        }
    }
}
