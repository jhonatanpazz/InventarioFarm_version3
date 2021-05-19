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
    public partial class Facturar : Form
    {
        public Facturar()
        {
            InitializeComponent();
        }

        double total = 0.0;

        M_Factura sql = new Modelo.M_Factura();
        C_Factura obj = new C_Factura();
        
        private void Facturar_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = sql.CargarcomboboxTablaCliente();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "idcliente";

            

            cmbProducto.DataSource = sql.CargarcomboboxTablaProducto();
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "idproducto";


            cmbEmpleado.DataSource = sql.CargarcomboboxTablaEmpleado();
            cmbEmpleado.DisplayMember = "Nombre";
            cmbEmpleado.ValueMember = "idempleado";

            cmbSucursal.DataSource = sql.CargarcomboboxTablaSucursal();
            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "idsucursal";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double suma, preciop;
            int cant;

            cmbPrecio.DataSource = sql.BuscarProducto(cmbProducto.Text);
            cmbPrecio.DisplayMember = "Precio";

            preciop = double.Parse(cmbPrecio.Text);

            cant = int.Parse(txtCantidad.Text);
            suma = (cant * preciop);

            DGVFactura.Rows.Add(cmbProducto.SelectedValue.ToString(), cmbProducto.Text, cmbPrecio.Text, txtCantidad.Text, suma);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
        

                //String pre = txtTotalp.Text;

                obj.idcliente = cmbCliente.SelectedValue.ToString();
                obj.idempleado = cmbEmpleado.SelectedValue.ToString();
                obj.idsucursal = cmbSucursal.SelectedValue.ToString();
                obj.FechaFacturacion = txtFechaF.Text;
                obj.Total = txtTotalp.Text;

                txtTotalp.Clear();
                int resultado = sql.AgregarFactura(obj);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
               
                }
                else
                {
                    MessageBox.Show("Datos No Guardados", "Datos no Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
           
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < DGVFactura.Rows.Count; i++)
            {

                total = (total + Convert.ToDouble(DGVFactura.Rows[i].Cells[4].Value));
            }

            
            txtTotalp.Text = "" + total;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < DGVFactura.SelectedRows.Count; i++)
            {
                DGVFactura.Rows.Remove(DGVFactura.SelectedRows[i]);
               
            }

        }

        private void btnImprimirClase_Click(object sender, EventArgs e)
        {
            ReportesFactura nw = new ReportesFactura();
            nw.ShowDialog();
        }
    }
}
