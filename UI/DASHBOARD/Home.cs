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

namespace UI.DASHBOARD
{
    public partial class Home : Form
    {
        DataGridViewComboBoxEditingControl dgvCombo;
        int indice_fila_aborrar = -1;
        DataGridViewCellStyle estilo = null;
        //public Usuario user;
        //LOGIN login;
        // variable para ver si llamamos o no a despchar orden
        public bool llamamos_a_buscar = false;
        public Home()
        {
            InitializeComponent();
            /*user = new Usuario();
            user.ID = 420;
            user.NombreUsuario = "armando";
            user.NombreCompleto = "Armando Sandino";
            user.Tipo = "ventas";//admin//bodega
            */
        }
        /*public Home(LOGIN user)
        {
            InitializeComponent();
            this.login = user;
            this.user = login.usuario;
        }*/

        private void Home_Load(object sender, EventArgs e)
        {
            //DataSet da = new DataSet();
            //da.Tables.Add();
            //da.WriteXml(@"",System.Data.XmlWriteMode.WriteSchema);

            // este bloque es el valido para esto
            /*if (user.Tipo.Equals("ventas"))
            {
                panel_principal.Enabled = false;
                proveedorDeDatosToolStripMenuItem.Enabled = false;
                tsb_despachar_orden.Enabled = false;
                tsb_agregar_orden.Enabled = false;
                registrarToolStripMenuItem.Enabled = false;
                gestionarToolStripMenuItem.Enabled = false;
                consultarToolStripMenuItem.Enabled = false;
            }
            if (user.Tipo.Equals("bodega"))
            {
                proveedorDeDatosToolStripMenuItem.Enabled = false;
            }*/
        }
        private void tsb_despachar_orden_Click(object sender, EventArgs e)
        {
        }

        private void tsb_registrar_Click(object sender, EventArgs e)
        {
            /*RegistraProducto re = new RegistraProducto();
            re.ShowDialog();*/
        }

        private void dgv_regis_entradas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // MessageBox.Show(" si Dios");

        }

        private void dgv_regis_entradas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            /*DataGridViewRow fila = dgv_regis_entradas.Rows[e.RowIndex];
            if (e.ColumnIndex == 0)
            {// si es el P/N

                if (fila.Cells[e.ColumnIndex].Value != null &&
                !string.IsNullOrEmpty(fila.Cells[e.ColumnIndex].Value.ToString()))
                {
                    String cadena = fila.Cells[e.ColumnIndex].Value.ToString();
                    List<Object> lista = OperacionesBodega.verificar_PN(cadena);
                    bool res = Convert.ToBoolean(lista[0]);
                    String valor = Convert.ToString(lista[1]);
                    fila.Cells[1].Value = valor;
                }
            }

            if (e.ColumnIndex == 3) // estoy en la columna cantidad
            {
                if (dgv_regis_entradas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null
                    &&
                    !string.IsNullOrEmpty(dgv_regis_entradas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                {
                    String cadena = fila.Cells[e.ColumnIndex].Value.ToString();
                    if (!Utileria.EsNumero(cadena))
                    {
                        MessageBox.Show("La cantidad debe de ser un valor entero"); return;
                    }
                }
            }*/

        }


        private void bt_registrar_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                if (dgv_regis_entradas.RowCount - 1 <= 0)
                {
                    MessageBox.Show("No hay registros que guardar."); return;
                }
                else
                {
                    if (verificar_celdas_vacias())
                    {
                        MessageBox.Show("En algún registro se necesita más información, por favor agregalo e inténtelo luego, Gracias."); return;
                    }

                }
                List<DetalleProducto> lista = new List<DetalleProducto>();
                bloquear_controles_mientras();
                pgb_barra_de_estado.Visible = true;
                pgb_barra_de_estado.Minimum = 0;
                pgb_barra_de_estado.Value = 1;
                pgb_barra_de_estado.Step = 1;
                pgb_barra_de_estado.Maximum = dgv_regis_entradas.RowCount - 1;
                bool zen = false;//zentinela para ver si todos los datos se guardaron
                int contador = 0;
                // foreach (DataGridViewRow row in dgv_regis_entradas.Rows)
                for (int i = 0; i < dgv_regis_entradas.RowCount - 1; i++)
                {
                    DataGridViewRow fila = dgv_regis_entradas.Rows[i];
                    DetalleProducto pro = new DetalleProducto();
                    //verificamos que le numero de parte exista
                    List<Object> res = OperacionesBodega.verificar_PN(fila.Cells[0].Value.ToString());
                    bool si = (bool)res[0];
                    if (false == si)
                    {
                        fila.DefaultCellStyle.BackColor = Color.Yellow;// cambiar color de la fila seleccionada
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                        fila.DefaultCellStyle.SelectionBackColor = Color.Black;
                        fila.DefaultCellStyle.SelectionForeColor = Color.White;
                        desbloquear_controles_mientras();
                        pgb_barra_de_estado.Visible = false;
                        MessageBox.Show("En  el registro de la fila "
                            + (i + 1) + " se especificó un producto con un número parte que no existe.");
                        fila.ErrorText = "En  el registro de la fila "
                            + (i + 1) + " se especificó un producto con un número parte que no existe.";

                        return;
                    }
                    //antes de recorrer las celdas ,verificamos que la localizacion exista 
                    if (!OperacionesBodega
                        .verificar_ubicacion(fila.Cells["LOCALIZACION"].Value.ToString().ToUpper()))
                    {
                        MessageBox.Show("La ubicación definida para el producto con numero de parte "
                            + fila.Cells[0].Value.ToString() + " de la fila " + (i + 1) + ", no está etiquetada en la bodega.");
                        fila.DefaultCellStyle.BackColor = Color.YellowGreen;// cambiar color de la fila seleccionada
                        fila.DefaultCellStyle.ForeColor = Color.Black;
                        fila.DefaultCellStyle.SelectionBackColor = Color.Black;
                        fila.DefaultCellStyle.SelectionForeColor = Color.White;
                        desbloquear_controles_mientras();
                        pgb_barra_de_estado.Visible = false;
                        fila.ErrorText = "La ubicación definida para el producto con numero de parte "
                            + fila.Cells[0].Value.ToString() + " de la fila " + (i + 1) + ", no está etiquetada en la bodega.";
                        return;
                    }
                    //for (int c = 0; c < dgv_regis_entradas.Rows[i].Cells.Count; c++) { }
                    pro.PN = fila.Cells[0].Value.ToString().ToUpper();
                    pro.LOTE = fila.Cells["LOTE"].Value.ToString().ToUpper();
                    if (!Utileria.EsNumero(fila.Cells["CANTIDAD"].Value.ToString()))
                    {
                        MessageBox.Show("La cantidad definida para el producto con numero de parte "
            + fila.Cells[0].Value.ToString() + " de la fila " + (i + 1) + ", debe de ser un valor entero.");
                        desbloquear_controles_mientras();
                        pgb_barra_de_estado.Visible = false;
                        return;
                    }
                    else
                        pro.EXISTENCIA = Convert.ToInt32(fila.Cells["CANTIDAD"].Value.ToString());

                    pro.LOCALIZACION = fila.Cells["LOCALIZACION"].Value.ToString();
                    pro.FECHAINGRESO = DateTime.Now;

                    lista.Add(pro); pgb_barra_de_estado.PerformStep();//avanza en la barra segun la propiedad Step


                } //end for
                //si los registros de la grilla son validos, pasamos a insertarlos

                pgb_barra_de_estado.Visible = false;//ocultamos la barra antes de volverla a mostrar
                desbloquear_controles_mientras();

                bloquear_controles_mientras();
                pgb_barra_de_estado.Visible = true;
                pgb_barra_de_estado.Minimum = 0;
                pgb_barra_de_estado.Value = 1;
                pgb_barra_de_estado.Step = 1;
                pgb_barra_de_estado.Maximum = lista.Count;

                for (int i = 0; i < lista.Count; i++)
                {
                    //this.RunLongTask("juan", i ); //este metodo es genial se llama y no interrumpe la ejecucion del programa

                    if (!OperacionesBodega.operacionIUD(lista[i], "i"))
                    {
                        MessageBox.Show("La operación no salió bien, comunicate con el administrador de base de datos para determinar qué sucedió, antes de continuar.");
                        desbloquear_controles_mientras();
                        pgb_barra_de_estado.Visible = false;
                        zen = false;
                        return;
                    }
                    else
                    {
                        zen = true; contador++;
                        pgb_barra_de_estado.PerformStep();//avanza en la barra segun la propiedad Step
                    }

                }//end for
                if (contador == lista.Count && zen == true)
                {
                    MessageBox.Show("Los datos fueron almacenados exitosamente.");
                    dgv_regis_entradas.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de " + ex.Message + " EN " + ex.StackTrace.ToString());
            }
            finally { pgb_barra_de_estado.Visible = false; desbloquear_controles_mientras(); }*/
        }


        private void bt_consultar_Click(object sender, EventArgs e)
        {

            /*Busqueda bus = new Busqueda();
            bus.ShowDialog();*/
        }

        //cuando se da click sobre o registro o cualquier fila de una celda
        private void dgv_regis_entradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DataGridViewRow fila = dgv_regis_entradas.CurrentRow;
            if (fila.Selected)
            {

                if (indice_fila_aborrar != -1)
                {// si no es la primera vez que se selecciona una fila

                    dgv_regis_entradas.Rows[indice_fila_aborrar].DefaultCellStyle = estilo;//establecer estilo anterior

                    // recuperar estilo de la fila seleccionada
                    estilo = fila.InheritedStyle;
                    indice_fila_aborrar = fila.Index;
                }
                else
                { // si es el primer click
                    estilo = fila.InheritedStyle;
                    indice_fila_aborrar = fila.Index;
                }
                //MessageBox.Show("indice "+ fila.Index+" cantidad "+ (dgv_regis_entradas.RowCount)+" "+(dgv_regis_entradas.RowCount-1) );
                fila.DefaultCellStyle.BackColor = Color.Green;// cambiar color de la fila seleccionada
                fila.DefaultCellStyle.ForeColor = Color.White;
                fila.DefaultCellStyle.SelectionBackColor = Color.Black;
                fila.DefaultCellStyle.SelectionForeColor = Color.White;
            }*/
        }

        private void borrar_regsitro_Click(object sender, EventArgs e)
        {
            /*if (indice_fila_aborrar == -1)
            {
                MessageBox.Show("Debe seleccionar el registro o fila a eliminar."); return;
            }
            if ((indice_fila_aborrar == 0 && dgv_regis_entradas.RowCount == 1) ||
                (indice_fila_aborrar == dgv_regis_entradas.RowCount - 1))
            {
                MessageBox.Show("Disculpe esta fila vacía no puede ser eliminada");
                indice_fila_aborrar = -1;
                return;
            }
            dgv_regis_entradas.Rows.RemoveAt(indice_fila_aborrar); indice_fila_aborrar = -1;*/
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Consultar con = new Consultar();
            con.ShowDialog();*/
        }

        //VERIFICAR CELDAS VACIAS TOMANDO ENCUENTA LA ULTIMA FILA DE RELLENO
        private bool verificar_celdas_vacias()
        {
            bool bCampoVacio = false;
            //MessageBox.Show("count " + dgv_regis_entradas.RowCount + " menos  " + (dgv_regis_entradas.RowCount - 1));
            if (dgv_regis_entradas.RowCount - 1 > 0)
            {

                for (int i = 0; i < dgv_regis_entradas.RowCount - 1; i++)
                {
                    foreach (DataGridViewCell dc in dgv_regis_entradas.Rows[i].Cells)
                    {
                        if (dc.Value == null || string.IsNullOrEmpty(dc.Value.ToString()))
                        {
                            bCampoVacio = true;
                        }
                    }
                }
            }
            return bCampoVacio;
        }

        // metodo asincrono para ejcutar tareas en segundo plano
        private async Task RunLongTask(string NameThread, int otro)
        {
            lb_titulo.Text = otro.ToString();
            MessageBox.Show("es " + otro);
            /*for (var i = 0; i < 4; i++)
            {
                await Task.Delay(5000);
                Console.WriteLine("Executing Method..." + NameThread);
                MessageBox.Show("esta en el ciclo");
            }
            MessageBox.Show(" ya salio del ciclo"  );
            Console.WriteLine("End Async Method..." + NameThread);*/
        }
        /*        await Task.Factory.StartNew(() =>
        {
            Console.WriteLine(Thread.CurrentContext.ContextID);
            for (var i = 0; i < 4; i++)
            {
                Task.Delay(5000);
                Console.WriteLine("Executing..." + NameThread);
            }
        });*/

        void bloquear_controles_mientras()
        {
            dgv_regis_entradas.Enabled = false;
            bt_consultar.Enabled = false;
            bt_registrar.Enabled = false;
            bt_borrar_regsitro.Enabled = false;
        }
        void desbloquear_controles_mientras()
        {
            dgv_regis_entradas.Enabled = true;
            bt_consultar.Enabled = true;
            bt_registrar.Enabled = true;
            bt_borrar_regsitro.Enabled = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Info_Sorftware i = new Info_Sorftware();
            i.ShowDialog();*/
        }
        private void tsb_agregar_orden_Click(object sender, EventArgs e)
        {
            /*Agregar_Orden orde = new Agregar_Orden(this);
            orde.ShowDialog();
            llamar_a_BUSQUEDA();*/
        }
        private void llamar_a_BUSQUEDA()
        {
            if (llamamos_a_buscar)
            {
                /*Busqueda bus = new Busqueda();
                bus.ShowDialog();*/
            }
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*GestionarClientes ges = new GestionarClientes();
            ges.ShowDialog();*/
        }

        private void item_regi_orden_Click(object sender, EventArgs e)
        {
            /*Agregar_Orden orde = new Agregar_Orden(this);
            orde.ShowDialog();
            llamar_a_BUSQUEDA();*/
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*RegistraProducto re = new RegistraProducto();
            re.ShowDialog();*/
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*GestionarOrdenes ge = new GestionarOrdenes(this);
            ge.ShowDialog();*/
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*GestionarChoferes ge = new GestionarChoferes();
            ge.ShowDialog();*/
        }

        private void proveedorDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ProveedorDB p = new ProveedorDB();
            p.ShowDialog();*/
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.login.Show();
        }

        private void tsb_despachar_orden_Click_1(object sender, EventArgs e)
        {
            /*Busqueda bus = new Busqueda();
            bus.ShowDialog();*/
        }

        private void tsb_buscar_productos_Click(object sender, EventArgs e)
        {
            /*Consultar con = new Consultar(this);
            con.ShowDialog();*/
        }

        /********************/
        /********************/
        /********************/
        //generamos el reporte de existencias

        private void gereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*List<Object> res = OperacionesBodega.sacar_todos_los_productos();
            bool si = (bool)res[0];
            if (!si)
            {
                MessageBox.Show("Disculpa pero para generar un reporte de existencia al menos tienen que haber productos registrados.",
                    "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Esto puede durar unos minutos, espere por favor.",
         "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Enabled = false;

            //sacamos las existencias de cada producto
            List<DetalleProducto> datos = res[1] as List<DetalleProducto>;
            int tam = datos.Count;
            pgb_barra_de_estado.Visible = true;
            pgb_barra_de_estado.Minimum = 0;
            pgb_barra_de_estado.Value = 1;
            pgb_barra_de_estado.Step = 1;
            pgb_barra_de_estado.Maximum = tam;

            for (int i = 0; i < tam; i++)
            {
                String sql = "SELECT sum(dbo.Principal.Cantidad) as suma"
                                 + " FROM dbo.Principal WHERE dbo.Principal.Part_number='" + datos[i].PN + "' ";
                int existencias = OperacionesOrdenes.sacar_existencia_PN_UBI(sql);
                if (existencias != -1)
                    datos[i].EXISTENCIA = existencias;
                else
                    datos[i].EXISTENCIA = 0;

                pgb_barra_de_estado.PerformStep();
            }
            GENERAR_REPORTES.generar_reporte_de_exitencias(datos, user);
            pgb_barra_de_estado.Visible = false;
            this.Enabled = true;*/

        }



    }
}
