using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.sct;
using SHARED.UTILS;

namespace UI.ROLE
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Rol record = new Rol( uwRoles );
            record.Nombre = "Otro rol";
            record.Descripcion = "Description del rol ";

            record.IdEstadoRegistro = true; // record active
            record.FechaCreacion = DateTime.Now;
            record.IdUsuarioCreacion = 1; // the admin
            record.DireccionEquipoCreacion = Util.getIp(); // get ip my computer
            record.FechaModificacion = DateTime.Now;
            record.IdUsuarioModificacion = 1; // is admin
            record.DireccionEquipoModificacion = Util.getIp();

            record.Save();
            uwRoles.CommitChanges();
        }
    }
}
