using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.DASHBOARD;
using UI.LOGIN;
using UI.sct;
using UI.ROLE;

namespace SCT
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

             XpoDefault.DataLayer = XpoDefault.GetDataLayer(
                UI.sct.ConnectionHelper.ConnectionString,
                DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema
                );
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Roles());
        }
    }
}
