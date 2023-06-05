using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace aplicacionTullio
{
    public partial class IngresoClientes : Form
    {
        public IngresoClientes()
        {
            InitializeComponent();
        }

        MySqlConnection conection = new MySqlConnection("server=localhost;UserControl id=root;password=;database=dbcliente;sslMode=none");
        MySqlCommand command;
        MySqlDataAdapter dataAdapter;
        DataTable dataTable;
        string sql;
        string clienteid;
        int resultado;

        private void MuestraCliente()
        {
            try
            {
                
                sql = "select clienteID, nombre, apellido, dni_cuit From dbcliente";
                conection.Open();
                command = new MySqlCommand();
                command.Connection = conection;
                command.CommandText = sql;
                dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                //aqui iria un datagrid
                //dgvClientes.DataSource = dataAdapter;

                txtApellido.Clear();
                txtNombre.Clear();
                txtDNIC.Clear();
                //txtEtcétera....Clear();
                btnGrabar.Enabled = true;
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conection.Close();
                dataAdapter.Dispose();
            }
        }
        private void GuardarDatos()
        {
            try {
                sql = "Insert into dbclientes(Nombre, Apellido, cuit_cuil) values('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDNIC.Text + "')";
               
            conection.Open();
            command = new MySqlCommand();
            command.Connection = conection;
            command.CommandText = sql;
            resultado = command.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Guardado con exito", "Guardado");
            }
            else
            {
                MessageBox.Show("Falló la ejecución", "Error");
            }
            }
            catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
            finally {
                conection.Close();
            }
        }
        private void actualizarDatos()
        {
            try
            {
                sql = "Update dbclientes set Nombre='" + txtNombre.Text + "', Apellido='" + txtApellido.Text + "', dni_cuit='" + txtDNIC.Text + "' Where clienteid=" + clienteid;
                conection.Open();
                command = new MySqlCommand();
                command.Connection = conection;
                command.CommandText = sql;
                resultado = command.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Actualizado con exito", "Actualizado");
                }
                else
                {
                    MessageBox.Show("Falló la ejecución", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conection.Close();
               
            }
        }
        private void eliminarDatos()
        {
            try
            {
                sql = "Delete From dbcliente Where clienteid=" + clienteid;
                conection.Open();
                command = new MySqlCommand();
                command.Connection = conection;
                command.CommandText = sql;
                resultado = command.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado con exito", "Eliminado");
                }
                else
                {
                    MessageBox.Show("Falló la ejecución", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conection.Close();

            }
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTel.Clear();
            txtDNIC.Clear();
            cbxLocalidad.SelectedIndex = 0;
            txtCalle.Clear();
            txtCalleNro.Clear();
        }

      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
