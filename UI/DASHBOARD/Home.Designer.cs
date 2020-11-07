namespace UI.DASHBOARD
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.dgv_regis_entradas = new System.Windows.Forms.DataGridView();
            this.PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.pgb_barra_de_estado = new System.Windows.Forms.ProgressBar();
            this.bt_borrar_regsitro = new System.Windows.Forms.Button();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.bt_registrar = new System.Windows.Forms.Button();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_regi_orden = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_agregar_orden = new System.Windows.Forms.ToolStripButton();
            this.tsl_bienvenido_usuario = new System.Windows.Forms.ToolStripLabel();
            this.tsb_despachar_orden = new System.Windows.Forms.ToolStripButton();
            this.tsb_cerrar_orden = new System.Windows.Forms.ToolStripButton();
            this.tsb_ver_protocolos = new System.Windows.Forms.ToolStripButton();
            this.tsb_buscar_productos = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regis_entradas)).BeginInit();
            this.panel_principal.SuspendLayout();
            this.MenuPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_regis_entradas
            // 
            this.dgv_regis_entradas.AllowUserToDeleteRows = false;
            this.dgv_regis_entradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_regis_entradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_regis_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_regis_entradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PN,
            this.DESCRIPCION,
            this.LOTE,
            this.CANTIDAD,
            this.LOCALIZACION});
            this.dgv_regis_entradas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_regis_entradas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_regis_entradas.Location = new System.Drawing.Point(20, 69);
            this.dgv_regis_entradas.Name = "dgv_regis_entradas";
            this.dgv_regis_entradas.Size = new System.Drawing.Size(1103, 511);
            this.dgv_regis_entradas.TabIndex = 17;
            this.dgv_regis_entradas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_regis_entradas_CellDoubleClick);
            this.dgv_regis_entradas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_regis_entradas_CellEndEdit);
            this.dgv_regis_entradas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_regis_entradas_EditingControlShowing);
            // 
            // PN
            // 
            this.PN.DividerWidth = 1;
            this.PN.FillWeight = 200F;
            this.PN.HeaderText = "P/N";
            this.PN.Name = "PN";
            this.PN.Width = 200;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DividerWidth = 1;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Width = 280;
            // 
            // LOTE
            // 
            this.LOTE.DividerWidth = 1;
            this.LOTE.HeaderText = "LOTE";
            this.LOTE.Name = "LOTE";
            this.LOTE.Width = 200;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DividerWidth = 1;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 180;
            // 
            // LOCALIZACION
            // 
            this.LOCALIZACION.DividerWidth = 1;
            this.LOCALIZACION.HeaderText = "LOCALIZACION";
            this.LOCALIZACION.Name = "LOCALIZACION";
            this.LOCALIZACION.Width = 200;
            // 
            // panel_principal
            // 
            this.panel_principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_principal.Controls.Add(this.pgb_barra_de_estado);
            this.panel_principal.Controls.Add(this.bt_borrar_regsitro);
            this.panel_principal.Controls.Add(this.bt_consultar);
            this.panel_principal.Controls.Add(this.lb_titulo);
            this.panel_principal.Controls.Add(this.bt_registrar);
            this.panel_principal.Controls.Add(this.dgv_regis_entradas);
            this.panel_principal.Location = new System.Drawing.Point(21, 110);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(1320, 604);
            this.panel_principal.TabIndex = 18;
            // 
            // pgb_barra_de_estado
            // 
            this.pgb_barra_de_estado.Location = new System.Drawing.Point(469, 268);
            this.pgb_barra_de_estado.Name = "pgb_barra_de_estado";
            this.pgb_barra_de_estado.Size = new System.Drawing.Size(370, 23);
            this.pgb_barra_de_estado.TabIndex = 105;
            this.pgb_barra_de_estado.Visible = false;
            // 
            // bt_borrar_regsitro
            // 
            this.bt_borrar_regsitro.BackColor = System.Drawing.Color.White;
            this.bt_borrar_regsitro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_borrar_regsitro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_borrar_regsitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_borrar_regsitro.ForeColor = System.Drawing.Color.Black;
            this.bt_borrar_regsitro.Location = new System.Drawing.Point(1156, 164);
            this.bt_borrar_regsitro.Name = "bt_borrar_regsitro";
            this.bt_borrar_regsitro.Size = new System.Drawing.Size(135, 70);
            this.bt_borrar_regsitro.TabIndex = 104;
            this.bt_borrar_regsitro.Text = "Borrar Registro Seleccionado";
            this.bt_borrar_regsitro.UseVisualStyleBackColor = false;
            this.bt_borrar_regsitro.Click += new System.EventHandler(this.borrar_regsitro_Click);
            // 
            // bt_consultar
            // 
            this.bt_consultar.BackColor = System.Drawing.Color.White;
            this.bt_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar.ForeColor = System.Drawing.Color.Black;
            this.bt_consultar.Location = new System.Drawing.Point(1156, 279);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(135, 58);
            this.bt_consultar.TabIndex = 103;
            this.bt_consultar.Text = "Despachar Ordene";
            this.bt_consultar.UseVisualStyleBackColor = false;
            this.bt_consultar.Visible = false;
            this.bt_consultar.Click += new System.EventHandler(this.bt_consultar_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(164, 17);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(298, 24);
            this.lb_titulo.TabIndex = 102;
            this.lb_titulo.Text = "Registrar entrada de productos";
            // 
            // bt_registrar
            // 
            this.bt_registrar.BackColor = System.Drawing.Color.White;
            this.bt_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrar.ForeColor = System.Drawing.Color.Black;
            this.bt_registrar.Location = new System.Drawing.Point(1156, 105);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(135, 40);
            this.bt_registrar.TabIndex = 101;
            this.bt_registrar.Text = "Guardar";
            this.bt_registrar.UseVisualStyleBackColor = false;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.gestionarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1370, 24);
            this.MenuPrincipal.TabIndex = 19;
            this.MenuPrincipal.Text = "MenuPrincipal";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_regi_orden,
            this.nuevoProductoToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // item_regi_orden
            // 
            this.item_regi_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.item_regi_orden.Name = "item_regi_orden";
            this.item_regi_orden.Size = new System.Drawing.Size(201, 22);
            this.item_regi_orden.Text = "Nueva lista de empaque";
            this.item_regi_orden.ToolTipText = "Registrar nueva orden de envío";
            this.item_regi_orden.Click += new System.EventHandler(this.item_regi_orden_Click);
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choferesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedorDeDatosToolStripMenuItem,
            this.ordenesToolStripMenuItem});
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // choferesToolStripMenuItem
            // 
            this.choferesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            this.choferesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.choferesToolStripMenuItem.Text = "Choferes";
            this.choferesToolStripMenuItem.ToolTipText = "Administrar Choferes";
            this.choferesToolStripMenuItem.Click += new System.EventHandler(this.choferesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.ToolTipText = "Administrar Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedorDeDatosToolStripMenuItem
            // 
            this.proveedorDeDatosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.proveedorDeDatosToolStripMenuItem.Name = "proveedorDeDatosToolStripMenuItem";
            this.proveedorDeDatosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.proveedorDeDatosToolStripMenuItem.Text = "Proveedor de Datos";
            this.proveedorDeDatosToolStripMenuItem.Click += new System.EventHandler(this.proveedorDeDatosToolStripMenuItem_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ordenesToolStripMenuItem.Text = "Listas de empaque";
            this.ordenesToolStripMenuItem.Click += new System.EventHandler(this.ordenesToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gereToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // gereToolStripMenuItem
            // 
            this.gereToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gereToolStripMenuItem.Name = "gereToolStripMenuItem";
            this.gereToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.gereToolStripMenuItem.Text = "Generar reporte de existencias actuales";
            this.gereToolStripMenuItem.Click += new System.EventHandler(this.gereToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(56, 56);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_agregar_orden,
            this.tsl_bienvenido_usuario,
            this.tsb_despachar_orden,
            this.tsb_cerrar_orden,
            this.tsb_ver_protocolos,
            this.tsb_buscar_productos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1370, 84);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_agregar_orden
            // 
            this.tsb_agregar_orden.AutoSize = false;
            this.tsb_agregar_orden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_agregar_orden.Image = ((System.Drawing.Image)(resources.GetObject("tsb_agregar_orden.Image")));
            this.tsb_agregar_orden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_agregar_orden.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.tsb_agregar_orden.Name = "tsb_agregar_orden";
            this.tsb_agregar_orden.Size = new System.Drawing.Size(80, 81);
            this.tsb_agregar_orden.Text = "Agregar nueva orden de envío";
            this.tsb_agregar_orden.Click += new System.EventHandler(this.tsb_agregar_orden_Click);
            // 
            // tsl_bienvenido_usuario
            // 
            this.tsl_bienvenido_usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_bienvenido_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsl_bienvenido_usuario.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsl_bienvenido_usuario.Name = "tsl_bienvenido_usuario";
            this.tsl_bienvenido_usuario.Size = new System.Drawing.Size(234, 81);
            this.tsl_bienvenido_usuario.Text = "SCE-SGA - Bienvenidos";
            // 
            // tsb_despachar_orden
            // 
            this.tsb_despachar_orden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_despachar_orden.Image = ((System.Drawing.Image)(resources.GetObject("tsb_despachar_orden.Image")));
            this.tsb_despachar_orden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_despachar_orden.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.tsb_despachar_orden.Name = "tsb_despachar_orden";
            this.tsb_despachar_orden.Size = new System.Drawing.Size(60, 81);
            this.tsb_despachar_orden.Text = "Despachar lista de empaque";
            this.tsb_despachar_orden.Click += new System.EventHandler(this.tsb_despachar_orden_Click_1);
            // 
            // tsb_cerrar_orden
            // 
            this.tsb_cerrar_orden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_cerrar_orden.Image = ((System.Drawing.Image)(resources.GetObject("tsb_cerrar_orden.Image")));
            this.tsb_cerrar_orden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cerrar_orden.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.tsb_cerrar_orden.Name = "tsb_cerrar_orden";
            this.tsb_cerrar_orden.Size = new System.Drawing.Size(60, 81);
            this.tsb_cerrar_orden.Text = "Cerrar Orden";
            this.tsb_cerrar_orden.Visible = false;
            // 
            // tsb_ver_protocolos
            // 
            this.tsb_ver_protocolos.AutoSize = false;
            this.tsb_ver_protocolos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ver_protocolos.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ver_protocolos.Image")));
            this.tsb_ver_protocolos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ver_protocolos.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.tsb_ver_protocolos.Name = "tsb_ver_protocolos";
            this.tsb_ver_protocolos.Size = new System.Drawing.Size(80, 81);
            this.tsb_ver_protocolos.Text = "Ver Informes de envios";
            this.tsb_ver_protocolos.ToolTipText = "Ver Informes de envios";
            this.tsb_ver_protocolos.Visible = false;
            // 
            // tsb_buscar_productos
            // 
            this.tsb_buscar_productos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_buscar_productos.Image = ((System.Drawing.Image)(resources.GetObject("tsb_buscar_productos.Image")));
            this.tsb_buscar_productos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_buscar_productos.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.tsb_buscar_productos.Name = "tsb_buscar_productos";
            this.tsb_buscar_productos.Size = new System.Drawing.Size(60, 81);
            this.tsb_buscar_productos.Text = "Buscar envios";
            this.tsb_buscar_productos.ToolTipText = "Buscar productos";
            this.tsb_buscar_productos.Click += new System.EventHandler(this.tsb_buscar_productos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MenuPrincipal);
            this.Controls.Add(this.panel_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_regis_entradas)).EndInit();
            this.panel_principal.ResumeLayout(false);
            this.panel_principal.PerformLayout();
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_regis_entradas;
        private System.Windows.Forms.Panel panel_principal;
        public System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.Label lb_titulo;
        public System.Windows.Forms.Button bt_consultar;
        public System.Windows.Forms.Button bt_borrar_regsitro;
        private System.Windows.Forms.ProgressBar pgb_barra_de_estado;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item_regi_orden;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_agregar_orden;
        private System.Windows.Forms.ToolStripLabel tsl_bienvenido_usuario;
        private System.Windows.Forms.ToolStripButton tsb_despachar_orden;
        private System.Windows.Forms.ToolStripButton tsb_cerrar_orden;
        private System.Windows.Forms.ToolStripButton tsb_ver_protocolos;
        private System.Windows.Forms.ToolStripButton tsb_buscar_productos;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIZACION;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gereToolStripMenuItem;
    }
}

