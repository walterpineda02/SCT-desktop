using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MODELS;
using SHARED.UTILS;

namespace UI.LOGIN
{
    public partial class LOGIN : Form
    {
        public User usuario;

        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            usuario = new User();
            // LEER_FICHERO_DE_CONFIGURACION();
            setDefaultUser();

        }

        // seed user
        private void setDefaultUser()  {
            string query = @"INSERT INTO [dbo].[Usuario] (" +
                "IdRol, Nombres, Apellidos, Sexo, DNI, FechaNacimiento, Telefono, Correo, Direccion, Ciudad, Pais, Usuario, Contrasena," +
                "Activo, IdEstadoRegistro, FechaCreacion, IdUsuarioCreacion, DireccionEquipoCreacion," +
                "FechaModificacion, IdUsuarioModificacion, DireccionEquipoModificacion" +
                ") VALUES (" +
                "@IdRol, @Nombres, @Apellidos, @Sexo, @DNI, @FechaNacimiento, @Telefono, @Correo, @Direccion, @Ciudad, @Pais, @Usuario, @Contrasena," +
                "@Activo, @IdEstadoRegistro, @FechaCreacion, @IdUsuarioCreacion, @DireccionEquipoCreacion," +
                "@FechaModificacion, @IdUsuarioModificacion, @DireccionEquipoModificacion" +
                ")";

            int rowsAffected =  uwLogin.ExecuteNonQuery( query,
                new string [] {
                    "IdRol",
                    "Nombres",
                    "Apellidos",
                    "Sexo",
                    "DNI",
                    "FechaNacimiento",
                    "Telefono",
                    "Correo",
                    "Direccion",
                    "Ciudad",
                    "Pais",
                    "Usuario",
                    "Contrasena",
                    "Activo",
                    "IdEstadoRegistro",
                    "FechaCreacion", "IdUsuarioCreacion", "DireccionEquipoCreacion",
                    "FechaModificacion", "IdUsuarioModificacion", "DireccionEquipoModificacion"
                },
                new object[] { "1", "root", "lastname", "M", "281-099494-0004L", DateTime.Now, "50534567834", "root@tiste.com",
                "Calle Elm",
                "Leon",
                "Nicaragua",
                "root",
                "pineda",
                0,
                true,
                DateTime.Now, 1, Util.getIp(),
                DateTime.Now, 1, Util.getIp()
                } );
           
        }

        private void LEER_FICHERO_DE_CONFIGURACION()
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "(*.txt)|*.txt|(*.pdf)|*.pdf|Todos (*.*)|*.*";
                file.FilterIndex = 2;
                file.RestoreDirectory = true; // si quiero  que noce refresque y busque dessde otra ubicacion  la pongo a false                
                //file.InitialDirectory = "C:\\Proyecto\\Mer FCM\\config.txt";
                file.InitialDirectory = "F:\\Practicas\\Mer FCM\\config.txt";
                file.FileName = "config.txt";

                //  if (file.ShowDialog() == DialogResult.OK)
                // {
                string line;

                // System.IO.StreamReader fi = new System.IO.StreamReader("F:\\Practicas\\Mer FCM\\config.txt");
                var ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)
                     .Replace("\\bin\\Debug", "\\configuracion");

                var fichero = System.IO.Path.Combine(ruta, "config.txt");

                //string[] lines = System.IO.File.ReadAllLines(@fichero);
                // string ruta = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0 ,6) + "/";

                //string  ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\configuracion\config.txt");
                // string ruta =
                //    System.IO.Path.Combine(Application.StartupPath.ToString().Replace("\\bin\\Debug","\\configuracion"), @"config.txt");

                //MessageBox.Show("GENIAL" + Application.StartupPath.ToString()  + " " +ruta);
                System.IO.StreamReader fi = new System.IO.StreamReader(fichero);

                //var carpeta = Environment.GetFolderPath( ruta );
                //var fichero = System.IO.Path.Combine(carpeta, );
                /*foreach (string linea in lines)
                {
                    // Use a tab to indent each line of the file.
                    Console.WriteLine("\t" + linea );
                }*/

                /*      string misDatos = Environment.GetFolderPath(Environment.SpecialFolders.ApplicationData) + "\\miCarpetaDeDatos";

      if (!Directory.Exists(misDatos))

      { // crear carpetas }

      Environment.CurrentDirectory = misDatos;

      A partir de ahi te puedes referir a cada una de las carpetas con misDatos + "\\data" etc.

      Cristian.*/

                int ca = 0;
                while ((line = fi.ReadLine()) != null)
                {

                    /*if (ca == 0) Conexion.setServidor(line);
                    if (ca == 1) Conexion.setDB(line);
                    if (ca == 2) Conexion.setUsuario(line);
                    if (ca == 3) { Conexion.setContraseña(line); }
                    */

                    ca++;
                    //MessageBox.Show("jajja" + file.SafeFileName.ToString()  + file.Title + file.DefaultExt + file.InitialDirectory );
                }

                fi.Close();

                // MessageBox.Show(si.ReadToEnd());  este metodo leee  de  todo   el  ficheroi asta  el   final  de los   tiempos 
                /*if (file.ReadOnlyChecked)
                {
                    Stream ki = file.OpenFile();
                    MessageBox.Show("" + file.FileName + " ");
                }*/
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Uppss  comuníquese con el administrador de  sistemas, para  que revise  la configuración de conexión al servidor de base de  datos (archivo config.txt) del paquete del programa"
                     + ex.Message + ex.StackTrace.ToString(), " NO PODRAS REALIZAR NADA CON ESTO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bt_acceder_Click(object sender, EventArgs e)
        {
            /*
            if (ct_usuario.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el su nombre usuario.",
                    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (ct_contraseña.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Ingrese su contraseña.",
                    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //+++++++
            if (ct_contraseña.Text.ToString().Trim().Equals("sandino") &&
                ct_usuario.Text.ToString().Trim().Equals("root"))
            {
                usuario.ID = 1;
                usuario.NombreUsuario = "root";
                usuario.NombreCompleto = "armando sandino";
                usuario.Contrasena = "sandino";
                usuario.Tipo = "admin";
                this.Hide();
                Principal pri = new Principal(this);
                pri.Show(); return;
            }
            //+++++++++

            List<Object> res = OperacionesUsuario.LOGIN(ct_usuario.Text.ToString().Trim(),
                ct_contraseña.Text.ToString().Trim());
            bool si = (bool)res[0];
            if (!si)
            {
                MessageBox.Show("Las credenciales de acceso son incorrectas.",
    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                usuario = res[1] as Usuario;
                this.Hide();
                Principal pri = new Principal(this);
                pri.Show();
            }
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
