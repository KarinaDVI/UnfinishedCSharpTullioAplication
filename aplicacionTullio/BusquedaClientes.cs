using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionTullio
{
    public partial class BusquedaClientes : Form
    {
        public BusquedaClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnPedidoNuevo_Click(object sender, EventArgs e)
        {
            NuevoPedido pedidos = new NuevoPedido();
            pedidos.Show();
        }

        private void txtBusquedaNro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBusquedaNombre_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {
            int nroCliente = int.Parse(txtBusquedaNro.Text.ToString());
            String nombreCLiente = txtBusquedaNombre.Text.ToString();

        }
    }
}
