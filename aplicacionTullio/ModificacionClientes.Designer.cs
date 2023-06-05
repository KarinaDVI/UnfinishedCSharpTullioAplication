namespace aplicacionTullio
{
    partial class ModificacionClientes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtObservaM = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregarLocalidadM = new System.Windows.Forms.Button();
            this.txtCPM = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxProvM = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAgregaLocalidadM = new System.Windows.Forms.TextBox();
            this.btnLimpiarM = new System.Windows.Forms.Button();
            this.btnModificarM = new System.Windows.Forms.Button();
            this.txtDNICM = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.tttTelM = new System.Windows.Forms.TextBox();
            this.txtCalleNroM = new System.Windows.Forms.TextBox();
            this.txtCalleM = new System.Windows.Forms.TextBox();
            this.cbxLocalidadM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click_1);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(357, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(208, 149);
            this.listView1.TabIndex = 89;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtObservaM
            // 
            this.txtObservaM.Location = new System.Drawing.Point(176, 409);
            this.txtObservaM.Name = "txtObservaM";
            this.txtObservaM.Size = new System.Drawing.Size(132, 23);
            this.txtObservaM.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 87;
            this.label13.Text = "Observaciones";
            // 
            // btnAgregarLocalidadM
            // 
            this.btnAgregarLocalidadM.Location = new System.Drawing.Point(327, 365);
            this.btnAgregarLocalidadM.Name = "btnAgregarLocalidadM";
            this.btnAgregarLocalidadM.Size = new System.Drawing.Size(113, 23);
            this.btnAgregarLocalidadM.TabIndex = 86;
            this.btnAgregarLocalidadM.Text = "Agregar localidad";
            this.btnAgregarLocalidadM.UseVisualStyleBackColor = true;
            this.btnAgregarLocalidadM.Click += new System.EventHandler(this.btnAgregarLocalidadM_Click);
            // 
            // txtCPM
            // 
            this.txtCPM.Location = new System.Drawing.Point(522, 313);
            this.txtCPM.Name = "txtCPM";
            this.txtCPM.Size = new System.Drawing.Size(54, 23);
            this.txtCPM.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(522, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 15);
            this.label12.TabIndex = 84;
            this.label12.Text = "CP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 83;
            this.label11.Text = "Provincia";
            // 
            // cbxProvM
            // 
            this.cbxProvM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxProvM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProvM.FormattingEnabled = true;
            this.cbxProvM.Items.AddRange(new object[] {
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
            this.cbxProvM.Location = new System.Drawing.Point(176, 260);
            this.cbxProvM.Name = "cbxProvM";
            this.cbxProvM.Size = new System.Drawing.Size(132, 23);
            this.cbxProvM.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(111, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 21);
            this.label10.TabIndex = 81;
            this.label10.Text = "Modificación de Clientes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 80;
            this.label9.Text = "Escriba localidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 79;
            this.label8.Text = "Nro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 78;
            this.label7.Text = "Calle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 77;
            this.label6.Text = "Localidad";
            // 
            // txtAgregaLocalidadM
            // 
            this.txtAgregaLocalidadM.Location = new System.Drawing.Point(176, 365);
            this.txtAgregaLocalidadM.Name = "txtAgregaLocalidadM";
            this.txtAgregaLocalidadM.Size = new System.Drawing.Size(132, 23);
            this.txtAgregaLocalidadM.TabIndex = 11;
            // 
            // btnLimpiarM
            // 
            this.btnLimpiarM.Location = new System.Drawing.Point(257, 458);
            this.btnLimpiarM.Name = "btnLimpiarM";
            this.btnLimpiarM.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarM.TabIndex = 14;
            this.btnLimpiarM.Text = "Limpiar";
            this.btnLimpiarM.UseVisualStyleBackColor = true;
            this.btnLimpiarM.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificarM
            // 
            this.btnModificarM.Location = new System.Drawing.Point(176, 458);
            this.btnModificarM.Name = "btnModificarM";
            this.btnModificarM.Size = new System.Drawing.Size(75, 23);
            this.btnModificarM.TabIndex = 13;
            this.btnModificarM.Text = "Modificar";
            this.btnModificarM.UseVisualStyleBackColor = true;
            // 
            // txtDNICM
            // 
            this.txtDNICM.Location = new System.Drawing.Point(176, 143);
            this.txtDNICM.Name = "txtDNICM";
            this.txtDNICM.Size = new System.Drawing.Size(132, 23);
            this.txtDNICM.TabIndex = 3;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(176, 78);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(132, 23);
            this.txtNombreM.TabIndex = 1;
            this.txtNombreM.TextChanged += new System.EventHandler(this.txtNombreM_TextChanged);
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(176, 110);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(132, 23);
            this.txtApellidoM.TabIndex = 2;
            // 
            // tttTelM
            // 
            this.tttTelM.Location = new System.Drawing.Point(176, 175);
            this.tttTelM.Name = "tttTelM";
            this.tttTelM.Size = new System.Drawing.Size(132, 23);
            this.tttTelM.TabIndex = 4;
            // 
            // txtCalleNroM
            // 
            this.txtCalleNroM.Location = new System.Drawing.Point(454, 313);
            this.txtCalleNroM.Name = "txtCalleNroM";
            this.txtCalleNroM.Size = new System.Drawing.Size(42, 23);
            this.txtCalleNroM.TabIndex = 9;
            // 
            // txtCalleM
            // 
            this.txtCalleM.Location = new System.Drawing.Point(327, 313);
            this.txtCalleM.Name = "txtCalleM";
            this.txtCalleM.Size = new System.Drawing.Size(100, 23);
            this.txtCalleM.TabIndex = 8;
            // 
            // cbxLocalidadM
            // 
            this.cbxLocalidadM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxLocalidadM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLocalidadM.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxLocalidadM.Items.AddRange(new object[] {
            "Localidad",
            "Villa Ballester",
            "Villa Martelli",
            "Villa Lynch",
            "San Martín",
            "San Andrés"});
            this.cbxLocalidadM.Location = new System.Drawing.Point(176, 313);
            this.cbxLocalidadM.Name = "cbxLocalidadM";
            this.cbxLocalidadM.Size = new System.Drawing.Size(132, 23);
            this.cbxLocalidadM.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "DNI/CUIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "NroContacto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nombre";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 15);
            this.label14.TabIndex = 91;
            this.label14.Text = "Email";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtObservaM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAgregarLocalidadM);
            this.Controls.Add(this.txtCPM);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxProvM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAgregaLocalidadM);
            this.Controls.Add(this.btnLimpiarM);
            this.Controls.Add(this.btnModificarM);
            this.Controls.Add(this.txtDNICM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.tttTelM);
            this.Controls.Add(this.txtCalleNroM);
            this.Controls.Add(this.txtCalleM);
            this.Controls.Add(this.cbxLocalidadM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem volverToolStripMenuItem;
        private ListView listView1;
        private TextBox txtObservaM;
        private Label label13;
        private Button btnAgregarLocalidadM;
        private TextBox txtCPM;
        private Label label12;
        private Label label11;
        private ComboBox cbxProvM;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtAgregaLocalidadM;
        private Button btnLimpiarM;
        private Button btnModificarM;
        private TextBox txtDNICM;
        private TextBox txtNombreM;
        private TextBox txtApellidoM;
        private TextBox tttTelM;
        private TextBox txtCalleNroM;
        private TextBox txtCalleM;
        private ComboBox cbxLocalidadM;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private Label label14;
    }
}