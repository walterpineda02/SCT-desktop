namespace UI.LOGIN
{
    partial class LOGIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_titulo_gest_cliente = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_acceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_contraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ct_usuario = new System.Windows.Forms.TextBox();
            this.uwLogin = new DevExpress.Xpo.UnitOfWork(this.components);
            this.session = new DevExpress.Xpo.Session(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uwLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.lb_titulo_gest_cliente);
            this.panel1.Controls.Add(this.bt_cancelar);
            this.panel1.Controls.Add(this.bt_acceder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ct_contraseña);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ct_usuario);
            this.panel1.Location = new System.Drawing.Point(503, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 323);
            this.panel1.TabIndex = 1;
            // 
            // lb_titulo_gest_cliente
            // 
            this.lb_titulo_gest_cliente.AutoSize = true;
            this.lb_titulo_gest_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo_gest_cliente.Location = new System.Drawing.Point(120, 9);
            this.lb_titulo_gest_cliente.Name = "lb_titulo_gest_cliente";
            this.lb_titulo_gest_cliente.Size = new System.Drawing.Size(125, 24);
            this.lb_titulo_gest_cliente.TabIndex = 115;
            this.lb_titulo_gest_cliente.Text = "Bienvenidos";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.White;
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.Black;
            this.bt_cancelar.Location = new System.Drawing.Point(187, 235);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(135, 40);
            this.bt_cancelar.TabIndex = 114;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_acceder
            // 
            this.bt_acceder.BackColor = System.Drawing.Color.White;
            this.bt_acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_acceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_acceder.ForeColor = System.Drawing.Color.Black;
            this.bt_acceder.Location = new System.Drawing.Point(20, 235);
            this.bt_acceder.Name = "bt_acceder";
            this.bt_acceder.Size = new System.Drawing.Size(135, 40);
            this.bt_acceder.TabIndex = 113;
            this.bt_acceder.Text = "Acceder";
            this.bt_acceder.UseVisualStyleBackColor = false;
            this.bt_acceder.Click += new System.EventHandler(this.bt_acceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 112;
            this.label1.Text = "Contraseña";
            // 
            // ct_contraseña
            // 
            this.ct_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_contraseña.Location = new System.Drawing.Point(30, 160);
            this.ct_contraseña.Multiline = true;
            this.ct_contraseña.Name = "ct_contraseña";
            this.ct_contraseña.PasswordChar = '*';
            this.ct_contraseña.Size = new System.Drawing.Size(292, 30);
            this.ct_contraseña.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 110;
            this.label4.Text = "Usuario";
            // 
            // ct_usuario
            // 
            this.ct_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_usuario.Location = new System.Drawing.Point(30, 80);
            this.ct_usuario.Multiline = true;
            this.ct_usuario.Name = "ct_usuario";
            this.ct_usuario.Size = new System.Drawing.Size(292, 30);
            this.ct_usuario.TabIndex = 0;
            // 
            // uwLogin
            // 
            this.uwLogin.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.uwLogin.TrackPropertiesModifications = false;
            // 
            // session
            // 
            this.session.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.session.TrackPropertiesModifications = false;
            // 
            // LOGIN
            // 
            this.AcceptButton = this.bt_acceder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(856, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uwLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox ct_usuario;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ct_contraseña;
        public System.Windows.Forms.Button bt_cancelar;
        public System.Windows.Forms.Button bt_acceder;
        private System.Windows.Forms.Label lb_titulo_gest_cliente;
        private DevExpress.Xpo.UnitOfWork uwLogin;
        private DevExpress.Xpo.Session session;
    }
}