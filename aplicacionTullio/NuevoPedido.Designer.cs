namespace aplicacionTullio
{
    partial class NuevoPedido
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
            this.menuPedidos = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.dateTimeEntrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbEnProceso = new System.Windows.Forms.RadioButton();
            this.rbListo = new System.Windows.Forms.RadioButton();
            this.menuPedidos.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPedidos
            // 
            this.menuPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuPedidos.Location = new System.Drawing.Point(0, 0);
            this.menuPedidos.Name = "menuPedidos";
            this.menuPedidos.Size = new System.Drawing.Size(800, 24);
            this.menuPedidos.TabIndex = 0;
            this.menuPedidos.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedido nro";
            // 
            // txtNroPedido
            // 
            this.txtNroPedido.Location = new System.Drawing.Point(131, 59);
            this.txtNroPedido.Name = "txtNroPedido";
            this.txtNroPedido.Size = new System.Drawing.Size(100, 23);
            this.txtNroPedido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(131, 98);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 23);
            this.txtCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detalle";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(131, 142);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(229, 71);
            this.txtDetalle.TabIndex = 3;
            // 
            // btnProgramar
            // 
            this.btnProgramar.Location = new System.Drawing.Point(62, 369);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(112, 23);
            this.btnProgramar.TabIndex = 7;
            this.btnProgramar.Text = "Programar Pedido";
            this.btnProgramar.UseVisualStyleBackColor = true;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // dateTimeEntrega
            // 
            this.dateTimeEntrega.Location = new System.Drawing.Point(178, 234);
            this.dateTimeEntrega.Name = "dateTimeEntrega";
            this.dateTimeEntrega.Size = new System.Drawing.Size(200, 23);
            this.dateTimeEntrega.TabIndex = 4;
            this.dateTimeEntrega.ValueChanged += new System.EventHandler(this.dateTimeEntrega_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de recepcion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbEnProceso);
            this.gbEstado.Controls.Add(this.rbListo);
            this.gbEstado.Location = new System.Drawing.Point(60, 275);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(188, 73);
            this.gbEstado.TabIndex = 11;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbEnProceso
            // 
            this.rbEnProceso.AutoSize = true;
            this.rbEnProceso.Location = new System.Drawing.Point(73, 47);
            this.rbEnProceso.Name = "rbEnProceso";
            this.rbEnProceso.Size = new System.Drawing.Size(83, 19);
            this.rbEnProceso.TabIndex = 6;
            this.rbEnProceso.TabStop = true;
            this.rbEnProceso.Text = "En proceso";
            this.rbEnProceso.UseVisualStyleBackColor = true;
            // 
            // rbListo
            // 
            this.rbListo.AutoSize = true;
            this.rbListo.Location = new System.Drawing.Point(73, 22);
            this.rbListo.Name = "rbListo";
            this.rbListo.Size = new System.Drawing.Size(50, 19);
            this.rbListo.TabIndex = 5;
            this.rbListo.TabStop = true;
            this.rbListo.Text = "Listo";
            this.rbListo.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeEntrega);
            this.Controls.Add(this.btnProgramar);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNroPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuPedidos);
            this.MainMenuStrip = this.menuPedidos;
            this.Name = "Form5";
            this.Text = "Form5";
            this.menuPedidos.ResumeLayout(false);
            this.menuPedidos.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuPedidos;
        private ToolStripMenuItem volverToolStripMenuItem;
        private Label label1;
        private TextBox txtNroPedido;
        private Label label2;
        private TextBox txtCliente;
        private Label label3;
        private TextBox txtDetalle;
        private Button btnProgramar;
        private DateTimePicker dateTimeEntrega;
        private Label label4;
        private GroupBox gbEstado;
        private RadioButton rbEnProceso;
        private RadioButton rbListo;
    }
}