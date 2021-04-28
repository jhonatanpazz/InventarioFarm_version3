using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventarioFarm_version3
{
    public partial class MantoMedicamentocs : Form
    {
        public MantoMedicamentocs()
        {
            InitializeComponent();
        }

        ConsultasSqlMedicamentos sql = new ConsultasSqlMedicamentos();

        private void cmbIdProvM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MantoMedicamentocs_Load(object sender, EventArgs e)
        {
            cmbIdProvM.DataSource = sql.CargarcomboboxTablaProducto_prov();
            cmbIdProvM.DisplayMember = "Empresa";
            cmbIdProvM.ValueMember = "idproveedor";

            cmbIdMarcaM.DataSource = sql.CargarcomboboxTablaProducto_marca();
            cmbIdMarcaM.DisplayMember = "Nombre";
            cmbIdMarcaM.ValueMember = "idmarca";


            cmbIdCatMedicamento.DataSource = sql.CargarcomboboxTablaProducto_Categoria();
            cmbIdCatMedicamento.DisplayMember = "NombreCategoria";
            cmbIdCatMedicamento.ValueMember = "idcategoria";

            DGVmedicamentos.DataSource = sql.MostrarDatosMedicamento();

        }

        private void btnInsertarMedicamento_Click(object sender, EventArgs e)
        {
            txtIdM.Text = DGVmedicamentos.Rows.Count.ToString();
            if (sql.InsertarMedicamento(txtNombreM.Text, cmbIdCatMedicamento.SelectedValue.ToString(), txtPrecioM.Text, txtDescpM.Text,
                cmbIdMarcaM.SelectedValue.ToString(), cmbIdProvM.SelectedValue.ToString()))
            {
                MessageBox.Show("Datos Insertados");
                DGVmedicamentos.DataSource = sql.MostrarDatosMedicamento();
                limpiarcajas();
            }
            else MessageBox.Show("Error");
        }

        private void btnEliminarMedicamento_Click(object sender, EventArgs e)
        {
           
                if (sql.EliminarMedicamento(txtIdM.Text))
                {
                    MessageBox.Show("Datos Eliminados");
                    DGVmedicamentos.DataSource = sql.MostrarDatosMedicamento();
                    limpiarcajas();
                }
                else MessageBox.Show("Error");
            
        }

        private void btnActualizarMedicamento_Click(object sender, EventArgs e)
        {
            if (sql.ActualizarMedicamento(txtIdM.Text, txtNombreM.Text, cmbIdCatMedicamento.SelectedValue.ToString(), txtPrecioM.Text, txtDescpM.Text,
                cmbIdMarcaM.SelectedValue.ToString(), cmbIdProvM.SelectedValue.ToString()))
            {
                MessageBox.Show("Datos Actualizados");
                DGVmedicamentos.DataSource = sql.MostrarDatosMedicamento();
                limpiarcajas();
            }
            else MessageBox.Show("Error");
        }

        private void DGVmedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVmedicamentos.Rows[e.RowIndex];
            txtIdM.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombreM.Text = Convert.ToString(fila.Cells[1].Value);
            cmbIdCatMedicamento.Text = Convert.ToString(fila.Cells[2].Value); 
            txtPrecioM.Text = Convert.ToString(fila.Cells[3].Value);
            txtDescpM.Text = Convert.ToString(fila.Cells[4].Value);
            cmbIdMarcaM.Text = Convert.ToString(fila.Cells[5].Value);
            cmbIdProvM.Text = Convert.ToString(fila.Cells[6].Value);

        }

        private void txtBuscarMedicamento_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarMedicamento.Text != "") { 

                DGVmedicamentos.DataSource = sql.BuscarMedicamento(txtBuscarMedicamento.Text);

            }
            else {

                DGVmedicamentos.DataSource = sql.MostrarDatosMedicamento();

            }

        }

        public void limpiarcajas()
        {
            txtIdM.Clear();
            txtNombreM.Clear();
            txtPrecioM.Clear();
            txtDescpM.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportesMedicamentos nw = new ReportesMedicamentos();
            nw.ShowDialog();
        }
    }
}
