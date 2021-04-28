using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace InventarioFarm_version3
{
    public partial class MantoClientes : Form
    {
        public MantoClientes()
        {
            InitializeComponent();
        }

        consultasSqlClientes sql = new consultasSqlClientes();

        private void MantoClientes_Load(object sender, EventArgs e)
        {
            try
            {
                DGVclientes.DataSource = sql.MostrarDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void DGVclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVclientes.Rows[e.RowIndex];
            txtIdCliente.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombreC.Text = Convert.ToString(fila.Cells[1].Value);
            txtApellidoC.Text = Convert.ToString(fila.Cells[2].Value);
            txtDireccionC.Text = Convert.ToString(fila.Cells[3].Value);
            txtTelefonoC.Text = Convert.ToString(fila.Cells[4].Value);
            txtEmailC.Text = Convert.ToString(fila.Cells[5].Value);

        }

        private void btnInsertarC_Click(object sender, EventArgs e)
        {

            try
            {
                txtIdCliente.Text = DGVclientes.Rows.Count.ToString();
                if (sql.Insertar(txtNombreC.Text, txtApellidoC.Text, txtDireccionC.Text, txtTelefonoC.Text,
                    txtEmailC.Text))

                {
                    MessageBox.Show("Datos Insertados");
                    DGVclientes.DataSource = sql.MostrarDatos();
                    Limpiarcajas();
                }

            }catch(Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
    
                
           
                
        
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            if(sql.Eliminar(txtIdCliente.Text))
            {
                MessageBox.Show("Datos Eliminados");
                DGVclientes.DataSource = sql.MostrarDatos();
                Limpiarcajas();
            }
            else MessageBox.Show("Error");
        }

        private void btnActualizarC_Click(object sender, EventArgs e)
        {
            if (sql.Actualizar(txtIdCliente.Text, txtNombreC.Text, txtApellidoC.Text, txtDireccionC.Text, txtTelefonoC.Text, txtEmailC.Text))
            {
                MessageBox.Show("Datos Actualizados");
                DGVclientes.DataSource = sql.MostrarDatos();

                Limpiarcajas();
            }
            else MessageBox.Show("Error");
        }

        private void txtbuscarCliente_TextChanged(object sender, EventArgs e)
        {
            if(txtbuscarCliente.Text != "")
            {
                DGVclientes.DataSource = sql.BuscarCliente(txtbuscarCliente.Text);
            }
            else
            {
                DGVclientes.DataSource = sql.MostrarDatos();
            }
        }
        
        public void Limpiarcajas()
        {
            txtIdCliente.Clear();
            txtNombreC.Clear();
            txtApellidoC.Clear();
            txtDireccionC.Clear();
            txtTelefonoC.Clear();
            txtEmailC.Clear();

        }

        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            ReporteClientes ver = new ReporteClientes();
            ver.ShowDialog();
        }
    }
}
