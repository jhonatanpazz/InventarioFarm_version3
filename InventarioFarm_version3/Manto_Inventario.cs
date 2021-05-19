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
    public partial class Manto_Inventario : Form
    {
        public Manto_Inventario()
        {
            InitializeComponent();
        }

        C_Inventario obj = new C_Inventario();
        M_Inventario sql = new M_Inventario();


        private void Manto_Inventario_Load(object sender, EventArgs e)
        {

            DGVInventario.DataSource = sql.MostrarInventario();

            cmbIdProducto.DataSource = sql.CargarcomboboxTablaInventarioP();
           // cmbIdSucursal.DisplayMember = "Nombre";
            cmbIdProducto.ValueMember = "idproducto";

        }

        private void DGVInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow fila = DGVInventario.Rows[e.RowIndex];
            txtIdInventario.Text = Convert.ToString(fila.Cells[0].Value);
            cmbIdProducto.Text = Convert.ToString(fila.Cells[1].Value);
            txtCantidad.Text = Convert.ToString(fila.Cells[2].Value);
            txtNombreP.Text = Convert.ToString(fila.Cells[3].Value);
            txtFechaI.Text = Convert.ToString(fila.Cells[4].Value);

        }

        private void btnInsertarI_Click(object sender, EventArgs e)
        {

            obj.idproducto = cmbIdProducto.Text;
            obj.Cantidad = txtCantidad.Text;
            obj.NombreProducto = txtNombreP.Text;
            obj.FechaInventario = txtFechaI.Text;
            
           

            int resultado = sql.AgregarInventario(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Ingresados", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVInventario.DataSource = sql.MostrarInventario();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Guardados", "Datos no Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnEliminarI_Click(object sender, EventArgs e)
        {

            obj.idinventario = txtIdInventario.Text;

            int resultado = sql.EliminarInventario(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Eliminados", "Datos Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVInventario.DataSource = sql.MostrarInventario();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Eliminados", "Datos no Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnActualizarI_Click(object sender, EventArgs e)
        {

            obj.idinventario = txtIdInventario.Text;
            obj.idproducto = cmbIdProducto.Text;
            obj.Cantidad = txtCantidad.Text;
            obj.NombreProducto = txtNombreP.Text;
            obj.FechaInventario = txtFechaI.Text;

            int resultado = sql.ActualizarInventario(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Actulizados ", "Datos Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVInventario.DataSource = sql.MostrarInventario();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Actualizados", "Datos no Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtBuscarI_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscarI.Text != "")
            {
                obj.NombreProducto = txtBuscarI.Text;

                DGVInventario.DataSource = sql.BuscarInventario(obj);

            }
            else
            {

                DGVInventario.DataSource = sql.MostrarInventario();

            }

        }

        public void limpiar()
        {

            txtIdInventario.Clear();
           
            txtCantidad.Clear();
            txtNombreP.Clear();
            txtFechaI.Clear();
            
        }
    }
}
