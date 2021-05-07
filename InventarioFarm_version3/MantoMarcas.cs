using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace InventarioFarm_version3
{
    public partial class MantoMarcas : Form
    {
        public MantoMarcas()
        {
            InitializeComponent();
        }

        M_Marca sql = new M_Marca();
        C_Marca obj = new C_Marca();
        

        private void MantoMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                DGVMarca.DataSource = sql.MostrarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DGVMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVMarca.Rows[e.RowIndex];
            txtIdMarca.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombreMarca.Text = Convert.ToString(fila.Cells[1].Value);

        }

        private void btnInsertarM_Click(object sender, EventArgs e)
        {
            obj.idmarca = txtIdMarca.Text;
            obj.Nombre = txtNombreMarca.Text;
           

            int resultado = sql.AgregarMarca(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Ingresados", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVMarca.DataSource = sql.MostrarMarcas();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Guardados", "Datos no Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void limpiar()
        {
            txtIdMarca.Clear();
            txtNombreMarca.Clear();
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            obj.idmarca = txtIdMarca.Text;

            int resultado = sql.EliminarMarca(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Eliminados", "Datos Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVMarca.DataSource = sql.MostrarMarcas();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Eliminados", "Datos no Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAtualizarM_Click(object sender, EventArgs e)
        {
            obj.idmarca = txtIdMarca.Text;
            obj.Nombre = txtNombreMarca.Text;
            
            int resultado = sql.ActualizarMarca(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Actualizados", "Datos Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVMarca.DataSource = sql.MostrarMarcas();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Actualizados", "Datos no Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtBuscarMarca_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscarMarca.Text != "")
            {

                obj.Nombre = txtBuscarMarca.Text;
                DGVMarca.DataSource = sql.BuscarMarca(obj);

            }
            else
            {

                DGVMarca.DataSource = sql.MostrarMarcas();

            }

        }
    }
}
