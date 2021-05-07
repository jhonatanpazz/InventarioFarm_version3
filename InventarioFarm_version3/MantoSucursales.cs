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
using Controlador;

namespace InventarioFarm_version3
{
    public partial class MantoSucursales : Form
    {
        public MantoSucursales()
        {
            InitializeComponent();
        }

        M_Sucursal sql = new M_Sucursal();
        C_Sucursal obj = new C_Sucursal();


        private void MantoSucursales_Load(object sender, EventArgs e)
        {
            try
            {
                DGVSucursales.DataSource = sql.MostrarSucursales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DGVSucursales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVSucursales.Rows[e.RowIndex];
            txtIDSucursal.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombreS.Text = Convert.ToString(fila.Cells[1].Value);
            txtDireccionS.Text = Convert.ToString(fila.Cells[2].Value);
            txtGerenteS.Text = Convert.ToString(fila.Cells[3].Value);
            txtCantidad.Text = Convert.ToString(fila.Cells[4].Value);
            

        }

        private void btnInsertarS_Click(object sender, EventArgs e)
        {

            obj.idsucursal = txtIDSucursal.Text;
            obj.Nombre = txtNombreS.Text;
            obj.Direccion = txtDireccionS.Text;
            obj.Gerente = txtGerenteS.Text;
            obj.Cantidad = txtCantidad.Text;

            int resultado = sql.AgregarSucursal(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Ingresados", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVSucursales.DataSource = sql.MostrarSucursales();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Guardados", "Datos no Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void limpiar()
        {
            txtIDSucursal.Clear();
            txtNombreS.Clear();
            txtDireccionS.Clear();
            txtGerenteS.Clear();
            txtCantidad.Clear();
        }

        private void btnEliminarS_Click(object sender, EventArgs e)
        {

            obj.idsucursal= txtIDSucursal.Text;

            int resultado = sql.EliminarSucursal(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Eliminados", "Datos Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVSucursales.DataSource = sql.MostrarSucursales();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Eliminados", "Datos no Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActualizarS_Click(object sender, EventArgs e)
        {

            obj.idsucursal = txtIDSucursal.Text;
            obj.Nombre = txtNombreS.Text;
            obj.Direccion = txtDireccionS.Text;
            obj.Gerente = txtGerenteS.Text;
            obj.Cantidad = txtCantidad.Text;

            int resultado = sql.ActualizarSucursal(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Actualizados", "Datos Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVSucursales.DataSource = sql.MostrarSucursales();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Actualizados", "Datos no Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBuscarSucursal_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarSucursal.Text != "")
            {

                obj.Nombre = txtBuscarSucursal.Text;
                DGVSucursales.DataSource = sql.BuscarSucursal(obj);

            }
            else
            {

                DGVSucursales.DataSource = sql.MostrarSucursales();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGerenteS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccionS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReporteS_Click(object sender, EventArgs e)
        {

        }
    }
}
