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
    public partial class MantoProveedores : Form
    {
        public MantoProveedores()
        {
            InitializeComponent();
        }

        C_Proveedor obj= new C_Proveedor();
        M_Proveedor sql = new M_Proveedor();

        
        private void MantoProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                DGVproveedor.DataSource = sql.MostrarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DGVproveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVproveedor.Rows[e.RowIndex];
            txtIdProveedor.Text = Convert.ToString(fila.Cells[0].Value);
            txtEmpresa.Text = Convert.ToString(fila.Cells[1].Value);
            txtNombreP.Text = Convert.ToString(fila.Cells[2].Value);
            txtDireccionP.Text = Convert.ToString(fila.Cells[3].Value);
            txtCiudadP.Text = Convert.ToString(fila.Cells[4].Value);
            txtRegion.Text = Convert.ToString(fila.Cells[5].Value);
            txtCodPostal.Text = Convert.ToString(fila.Cells[6].Value);
            txtPais.Text = Convert.ToString(fila.Cells[7].Value);
            txtEmailP.Text = Convert.ToString(fila.Cells[8].Value);
        }

        private void btnInsertarP_Click(object sender, EventArgs e)
        {
            obj.idproveedor = txtIdProveedor.Text;
            obj.Empresa = txtEmpresa.Text;
            obj.NombreContacto = txtNombreP.Text;
            obj.Direccion = txtDireccionP.Text;
            obj.Ciudad = txtCiudadP.Text;
            obj.Region = txtRegion.Text;
            obj.CodPostal = txtCodPostal.Text;
            obj.Pais = txtPais.Text;
            obj.Telefono = txtTelefono.Text;
            obj.Email = txtEmailP.Text;


            int resultado = sql.AgregarProveedor(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Ingresados", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVproveedor.DataSource = sql.MostrarProveedores();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Guardados", "Datos no Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void limpiar()
        {
            txtIdProveedor.Clear();
            txtEmpresa.Clear();
            txtNombreP.Clear();
            txtDireccionP.Clear();
            txtCiudadP.Clear();
            txtRegion.Clear();
            txtCodPostal.Clear();
            txtPais.Clear();
            txtTelefono.Clear();
            txtEmailP.Clear();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            obj.idproveedor = txtIdProveedor.Text;

            int resultado = sql.EliminarProveedor(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Eliminados", "Datos Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVproveedor.DataSource = sql.MostrarProveedores();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Eliminados", "Datos no Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            obj.idproveedor = txtIdProveedor.Text;
            obj.Empresa = txtEmpresa.Text;
            obj.NombreContacto = txtNombreP.Text;
            obj.Direccion = txtDireccionP.Text;
            obj.Ciudad = txtCiudadP.Text;
            obj.Region = txtRegion.Text;
            obj.CodPostal = txtCodPostal.Text;
            obj.Pais = txtPais.Text;
            obj.Telefono = txtTelefono.Text;
            obj.Email = txtEmailP.Text;

            int resultado = sql.ActualizarProveedor(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Actualizados", "Datos Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVproveedor.DataSource = sql.MostrarProveedores();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Actualizados", "Datos no Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtBuscarProve_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscarProve.Text != "")
            {

                obj.NombreContacto = txtBuscarProve.Text;
                DGVproveedor.DataSource = sql.BuscarProveedores(obj);

            }
            else
            {

                DGVproveedor.DataSource = sql.MostrarProveedores();

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
