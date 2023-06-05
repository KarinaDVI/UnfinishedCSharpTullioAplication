namespace aplicacionTullio
{
    partial class IngresoClientes
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregarLocalidad = new System.Windows.Forms.Button();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocalidadAgrega = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtDNIC = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCalleNro = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.cbxLocalidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuIngresoClientes = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.menuIngresoClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AccessibleDescription = "a";
            this.listView1.Location = new System.Drawing.Point(385, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(208, 149);
            this.listView1.TabIndex = 59;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.AccessibleDescription = "a";
            this.txtObservaciones.Location = new System.Drawing.Point(204, 418);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(132, 23);
            this.txtObservaciones.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AccessibleDescription = "a";
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 57;
            this.label13.Text = "Observaciones";
            // 
            // btnAgregarLocalidad
            // 
            this.btnAgregarLocalidad.AccessibleDescription = "a";
            this.btnAgregarLocalidad.Location = new System.Drawing.Point(355, 374);
            this.btnAgregarLocalidad.Name = "btnAgregarLocalidad";
            this.btnAgregarLocalidad.Size = new System.Drawing.Size(113, 23);
            this.btnAgregarLocalidad.TabIndex = 56;
            this.btnAgregarLocalidad.Text = "Agregar localidad";
            this.btnAgregarLocalidad.UseVisualStyleBackColor = true;
            // 
            // txtCP
            // 
            this.txtCP.AccessibleDescription = "a";
            this.txtCP.Location = new System.Drawing.Point(550, 322);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(54, 23);
            this.txtCP.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AccessibleDescription = "a";
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(550, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 15);
            this.label12.TabIndex = 54;
            this.label12.Text = "CP";
            // 
            // label11
            // 
            this.label11.AccessibleDescription = "a";
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "Provincia";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.AccessibleDescription = "a";
            this.cbxProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "Ciudad Autónoma de Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego, Antártida e Islas del Atlántico Sur",
            "Tucumán"});
            this.cbxProvincia.Location = new System.Drawing.Point(204, 269);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(132, 23);
            this.cbxProvincia.TabIndex = 6;
            this.cbxProvincia.SelectedIndexChanged += new System.EventHandler(this.cbxProvincia_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AccessibleDescription = "a";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(139, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 21);
            this.label10.TabIndex = 51;
            this.label10.Text = "Ingreso de Clientes";
            // 
            // label9
            // 
            this.label9.AccessibleDescription = "a";
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 50;
            this.label9.Text = "Escriba localidad";
            // 
            // label8
            // 
            this.label8.AccessibleDescription = "a";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 49;
            this.label8.Text = "Nro";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "a";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Calle";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "a";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Localidad";
            // 
            // txtLocalidadAgrega
            // 
            this.txtLocalidadAgrega.AccessibleDescription = "a";
            this.txtLocalidadAgrega.Location = new System.Drawing.Point(204, 374);
            this.txtLocalidadAgrega.Name = "txtLocalidadAgrega";
            this.txtLocalidadAgrega.Size = new System.Drawing.Size(132, 23);
            this.txtLocalidadAgrega.TabIndex = 11;
            // 
            // btnGrabar
            // 
            this.btnGrabar.AccessibleDescription = "a";
            this.btnGrabar.Location = new System.Drawing.Point(204, 467);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 13;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // txtDNIC
            // 
            this.txtDNIC.AccessibleDescription = "a";
            this.txtDNIC.Location = new System.Drawing.Point(204, 152);
            this.txtDNIC.Name = "txtDNIC";
            this.txtDNIC.Size = new System.Drawing.Size(132, 23);
            this.txtDNIC.TabIndex = 3;
            this.txtDNIC.TextChanged += new System.EventHandler(this.txtDNIC_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleDescription = "a";
            this.txtNombre.Location = new System.Drawing.Point(204, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.AccessibleDescription = "a";
            this.txtApellido.Location = new System.Drawing.Point(204, 119);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.AccessibleDescription = "a";
            this.txtTel.Location = new System.Drawing.Point(204, 184);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(132, 23);
            this.txtTel.TabIndex = 4;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // txtCalleNro
            // 
            this.txtCalleNro.AccessibleDescription = "a";
            this.txtCalleNro.Location = new System.Drawing.Point(482, 322);
            this.txtCalleNro.Name = "txtCalleNro";
            this.txtCalleNro.Size = new System.Drawing.Size(42, 23);
            this.txtCalleNro.TabIndex = 9;
            // 
            // txtCalle
            // 
            this.txtCalle.AccessibleDescription = "a";
            this.txtCalle.Location = new System.Drawing.Point(355, 322);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 23);
            this.txtCalle.TabIndex = 8;
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.AccessibleDescription = "a";
            this.cbxLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLocalidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxLocalidad.Items.AddRange(new object[] {
            "Localidad",
            "Villa Ballester",
            "Villa Martelli",
            "Villa Lynch",
            "San Martín",
            "San Andrés"});
            this.cbxLocalidad.Location = new System.Drawing.Point(204, 322);
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.Size = new System.Drawing.Size(132, 23);
            this.cbxLocalidad.TabIndex = 7;
            this.cbxLocalidad.SelectedIndexChanged += new System.EventHandler(this.cbxLocalidad_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AccessibleDescription = "a";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "DNI/CUIT";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "a";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "a";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "NroContacto";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "a";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "a";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // menuIngresoClientes
            // 
            this.menuIngresoClientes.AccessibleDescription = "a";
            this.menuIngresoClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuIngresoClientes.Location = new System.Drawing.Point(0, 0);
            this.menuIngresoClientes.Name = "menuIngresoClientes";
            this.menuIngresoClientes.Size = new System.Drawing.Size(800, 24);
            this.menuIngresoClientes.TabIndex = 61;
            this.menuIngresoClientes.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.AccessibleDescription = "a";
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.AccessibleDescription = "a";
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleDescription = "a";
            this.btnCancelar.Location = new System.Drawing.Point(294, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 15);
            this.label14.TabIndex = 63;
            this.label14.Text = "email";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "a";
            this.txtEmail.Location = new System.Drawing.Point(204, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // IngresoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAgregarLocalidad);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxProvincia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLocalidadAgrega);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtDNIC);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtCalleNro);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.cbxLocalidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuIngresoClientes);
            this.MainMenuStrip = this.menuIngresoClientes;
            this.Name = "IngresoClientes";
            this.Text = "Ingreso de clientes";
            this.menuIngresoClientes.ResumeLayout(false);
            this.menuIngresoClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private TextBox txtObservaciones;
        private Label label13;
        private Button btnAgregarLocalidad;
        private TextBox txtCP;
        private Label label12;
        private Label label11;
        private ComboBox cbxProvincia;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtLocalidadAgrega;
        private Button btnGrabar;
        private TextBox txtDNIC;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTel;
        private TextBox txtCalleNro;
        private TextBox txtCalle;
        private ComboBox cbxLocalidad;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuIngresoClientes;
        private ToolStripMenuItem volverToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button btnCancelar;
        private Label label14;
        private TextBox txtEmail;
    }
}