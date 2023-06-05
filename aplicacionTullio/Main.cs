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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoClientes ingreso = new IngresoClientes();

            ingreso.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPedido pedidos = new NuevoPedido();
            pedidos.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BusquedaClientes consulta = new BusquedaClientes();
            consulta.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificacionClientes modificacion = new ModificacionClientes();
            modificacion.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPedido pedidos = new NuevoPedido();
            pedidos.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
