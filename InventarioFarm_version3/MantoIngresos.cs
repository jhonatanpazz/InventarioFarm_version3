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
    public partial class MantoIngresos : Form
    {
        public MantoIngresos()
        {
            InitializeComponent();
        }

        C_Ingresos obj = new C_Ingresos();
        M_Ingresos sql = new M_Ingresos();

        private void btnInsertarI_Click(object sender, EventArgs e)
        {
            obj.idproducto = cmbIdP.Text;
            obj.idbodega = cmbIdB.Text;
            obj.FechaRegistro = txtfechaR.Text;
            obj.NoFactura = txtNfactura.Text;
            obj.Descripcion = txtdesc.Text;
            obj.idmarca = cmbIdM.Text;
            obj.CantidadIngreso = txtcant.Text;
            obj.CostoIngreso = txtcosto.Text;
            
            int resultado = sql.AgregarIngreso(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Ingresados", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DVGIngresos.DataSource = sql.MostrarDatosIngreso();
                //limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Guardados", "Datos no Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void MantoIngresos_Load(object sender, EventArgs e)
        {

            cmbIdP.DataSource = sql.CargarcomboboxTablaproducto();
            cmbIdP.ValueMember = "idproducto";

            cmbIdB.DataSource = sql.CargarcomboboxTablabodega();
            //cmbRolE.DisplayMember = "Nombre";
            cmbIdB.ValueMember = "idbodega";

            cmbIdM.DataSource = sql.CargarcomboboxTablamarca();
            //cmbIdM.DisplayMember = "Nombre";
            cmbIdM.ValueMember = "idmarca";

           DVGIngresos.DataSource = sql.MostrarDatosIngreso();
        }

        private void DVGIngresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow fila = DVGIngresos.Rows[e.RowIndex];
            txtidI.Text = Convert.ToString(fila.Cells[0].Value);
            cmbIdP.Text = Convert.ToString(fila.Cells[1].Value);
            cmbIdB.Text = Convert.ToString(fila.Cells[2].Value);
            txtfechaR.Text = Convert.ToString(fila.Cells[3].Value);
            txtNfactura.Text = Convert.ToString(fila.Cells[4].Value);
            txtdesc.Text = Convert.ToString(fila.Cells[5].Value);
            cmbIdM.Text = Convert.ToString(fila.Cells[6].Value);
            txtcant.Text = Convert.ToString(fila.Cells[7].Value);
            txtcosto.Text = Convert.ToString(fila.Cells[8].Value);
            
        }
    }
}
