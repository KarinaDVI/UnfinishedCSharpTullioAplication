namespace aplicacionTullio
{
    partial class BusquedaClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxResultado = new System.Windows.Forms.ComboBox();
            this.txtBusquedaNro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusquedaNombre = new System.Windows.Forms.TextBox();
            this.MenuBusqueda = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPedidoNuevo = new System.Windows.Forms.Button();
            this.btnVerPedido = new System.Windows.Forms.Button();
            this.MenuBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda por nro de cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxResultado
            // 
            this.cbxResultado.FormattingEnabled = true;
            this.cbxResultado.Location = new System.Drawing.Point(344, 57);
            this.cbxResultado.Name = "cbxResultado";
            this.cbxResultado.Size = new System.Drawing.Size(121, 23);
            this.cbxResultado.TabIndex = 2;
            // 
            // txtBusquedaNro
            // 
            this.txtBusquedaNro.Location = new System.Drawing.Point(198, 57);
            this.txtBusquedaNro.Name = "txtBusquedaNro";
            this.txtBusquedaNro.Size = new System.Drawing.Size(107, 23);
            this.txtBusquedaNro.TabIndex = 21;
            this.txtBusquedaNro.TextChanged += new System.EventHandler(this.txtBusquedaNro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Busqueda por nombre";
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.Location = new System.Drawing.Point(198, 96);
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(107, 23);
            this.txtBusquedaNombre.TabIndex = 4;
            this.txtBusquedaNombre.TextChanged += new System.EventHandler(this.txtBusquedaNombre_TextChanged);
            // 
            // MenuBusqueda
            // 
            this.MenuBusqueda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MenuBusqueda.Location = new System.Drawing.Point(0, 0);
            this.MenuBusqueda.Name = "MenuBusqueda";
            this.MenuBusqueda.Size = new System.Drawing.Size(800, 24);
            this.MenuBusqueda.TabIndex = 6;
            this.MenuBusqueda.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(26, 149);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(344, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 197);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPedidoNuevo
            // 
            this.btnPedidoNuevo.Location = new System.Drawing.Point(366, 361);
            this.btnPedidoNuevo.Name = "btnPedidoNuevo";
            this.btnPedidoNuevo.Size = new System.Drawing.Size(99, 23);
            this.btnPedidoNuevo.TabIndex = 11;
            this.btnPedidoNuevo.Text = "Pedido Nuevo";
            this.btnPedidoNuevo.UseVisualStyleBackColor = true;
            this.btnPedidoNuevo.Click += new System.EventHandler(this.btnPedidoNuevo_Click);
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Location = new System.Drawing.Point(475, 361);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(99, 23);
            this.btnVerPedido.TabIndex = 12;
            this.btnVerPedido.Text = "Ver pedidos";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            this.btnVerPedido.Click += new System.EventHandler(this.btnVerPedido_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerPedido);
            this.Controls.Add(this.btnPedidoNuevo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtBusquedaNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusquedaNro);
            this.Controls.Add(this.cbxResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuBusqueda);
            this.MainMenuStrip = this.MenuBusqueda;
            this.Name = "Form3";
            this.Text = "Form3";
            this.MenuBusqueda.ResumeLayout(false);
            this.MenuBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbxResultado;
        private TextBox txtBusquedaNro;
        private Label label2;
        private TextBox txtBusquedaNombre;
        private MenuStrip MenuBusqueda;
        private ToolStripMenuItem volverToolStripMenuItem;
        private MonthCalendar monthCalendar1;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button btnPedidoNuevo;
        private Button btnVerPedido;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}