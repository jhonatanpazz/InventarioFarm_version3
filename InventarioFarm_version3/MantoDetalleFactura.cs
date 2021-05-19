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
    public partial class MantoDetalleFactura : Form
    {
        public MantoDetalleFactura()
        {
            InitializeComponent();
        }

        C_DetalleFactura obj = new C_DetalleFactura();
        M_Dfactura sql = new M_Dfactura();

        private void btnIngresarDetalle_Click(object sender, EventArgs e)
        {

            obj.idfactura = cmbIdfactura.Text;
            obj.idproducto = cmbIdproducto.Text;
            obj.cantidad = txtcantidad.Text;
            obj.fecha = txtfecha.Text;



            int resultado = sql.AgregarInventario(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Ingresados", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVdetalle.DataSource = sql.MostrarDetalle();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Guardados", "Datos no Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVdetalle.Rows[e.RowIndex];
            txtidDFactura.Text = Convert.ToString(fila.Cells[0].Value);
            cmbIdproducto.Text = Convert.ToString(fila.Cells[1].Value);
            cmbIdfactura.Text = Convert.ToString(fila.Cells[2].Value);
            txtcantidad.Text = Convert.ToString(fila.Cells[3].Value);
            txtfecha.Text = Convert.ToString(fila.Cells[4].Value);

        }

        private void MantoDetalleFactura_Load(object sender, EventArgs e)
        {

            DGVdetalle.DataSource = sql.MostrarDetalle();

            cmbIdproducto.DataSource = sql.CargarcomboboxTablaProducto();
            // cmbIdSucursal.DisplayMember = "Nombre";
            cmbIdproducto.ValueMember = "idproducto";

            cmbIdfactura.DataSource = sql.CargarcomboboxTablaFactura();
            // cmbIdSucursal.DisplayMember = "Nombre";
            cmbIdfactura.ValueMember = "idfactura";
        }

        public void limpiar()
        {
            txtcantidad.Clear();
            txtfecha.Clear();
        }
    }
}
