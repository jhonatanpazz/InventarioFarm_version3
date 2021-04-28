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
    public partial class MantoEmpleado : Form
    {
        public MantoEmpleado()
        {
            InitializeComponent();
        }

        M_MantoEmpleado sql = new M_MantoEmpleado();
        C_MantoEmpleado obj = new C_MantoEmpleado();

        private void MantoEmpleado_Load(object sender, EventArgs e)
        {
            cmbCargo.DataSource = sql.CargarcomboboxTablaRoles();
            cmbCargo.DisplayMember = "Nombre";
            cmbCargo.ValueMember = "idrol";

            cmbRolE.DataSource = sql.CargarcomboboxTablaRoles();
            cmbRolE.DisplayMember = "Nombre";
            cmbRolE.ValueMember = "idrol";

            cmbIdSucursal.DataSource = sql.CargarcomboboxTablaSucursal();
            cmbIdSucursal.DisplayMember = "Nombre";
            cmbIdSucursal.ValueMember = "idsucursal";

            DGVempleado.DataSource = sql.MostrarDatosEmpleado();

        }

        private void btnInsertarE_Click(object sender, EventArgs e)
        {
            obj.Nombre = txtNombreE.Text;
            obj.Apellido = txtApellidoE.Text;
            obj.Cargo = cmbCargo.Text;
            obj.FechaNacimiento = txtFNaEmpleado.Text;
            obj.FechaContratacion = txtFContraE.Text;
            obj.direccion = txtDireccionE.Text;
            obj.idsucursal = cmbIdSucursal.SelectedValue.ToString();
            obj.Telefono = txtTelefonoE.Text;
            obj.Correo = txtCorreoE.Text;
            obj.DUI = txtDuiE.Text;
            obj.Usuario = txtUsuarioE.Text;
            obj.Contrasena = txtPasswordE.Text;
            obj.idrol = cmbRolE.SelectedValue.ToString();

            int resultado = sql.AgregarEmpleado(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Ingresados", "Datos Guardados ",MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVempleado.DataSource = sql.MostrarDatosEmpleado();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Guardados", "Datos no Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            obj.idempleado = txtIdE.Text;

            int resultado = sql.EliminarEmpleado(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Eliminados", "Datos Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVempleado.DataSource = sql.MostrarDatosEmpleado();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Eliminados", "Datos no Eliminados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DGVempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DGVempleado.Rows[e.RowIndex];
            txtIdE.Text = Convert.ToString(fila.Cells[0].Value);
            txtNombreE.Text = Convert.ToString(fila.Cells[1].Value);
            txtApellidoE.Text = Convert.ToString(fila.Cells[2].Value);
            cmbCargo.Text = Convert.ToString(fila.Cells[3].Value);
            txtFNaEmpleado.Text = Convert.ToString(fila.Cells[4].Value);
            txtFContraE.Text = Convert.ToString(fila.Cells[5].Value);
            txtDireccionE.Text = Convert.ToString(fila.Cells[6].Value);
            cmbIdSucursal.Text = Convert.ToString(fila.Cells[7].Value);
            txtTelefonoE.Text = Convert.ToString(fila.Cells[8].Value);
            txtCorreoE.Text = Convert.ToString(fila.Cells[9].Value);
            txtDuiE.Text = Convert.ToString(fila.Cells[10].Value);
            txtUsuarioE.Text = Convert.ToString(fila.Cells[11].Value);
            txtPasswordE.Text = Convert.ToString(fila.Cells[12].Value);
           cmbRolE.Text = Convert.ToString(fila.Cells[13].Value);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            obj.idempleado = txtIdE.Text;
            obj.Nombre = txtNombreE.Text;
            obj.Apellido = txtApellidoE.Text;
            obj.Cargo = cmbCargo.Text;
            obj.FechaNacimiento = txtFNaEmpleado.Text;
            obj.FechaContratacion = txtFContraE.Text;
            obj.direccion = txtDireccionE.Text;
            obj.idsucursal = cmbIdSucursal.SelectedValue.ToString();
            obj.Telefono = txtTelefonoE.Text;
            obj.Correo = txtCorreoE.Text;
            obj.DUI = txtDuiE.Text;
            obj.Usuario = txtUsuarioE.Text;
            obj.Contrasena = txtPasswordE.Text;
            obj.idrol = cmbRolE.SelectedValue.ToString();

            int resultado = sql.ActualizarEmpleado(obj);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Actulizados ", "Datos Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGVempleado.DataSource = sql.MostrarDatosEmpleado();
                limpiar();
            }
            else
            {
                MessageBox.Show("Datos No Actualizados", "Datos no Actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtBuscarE_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarE.Text != "")
            {
                obj.Nombre = txtBuscarE.Text;

                DGVempleado.DataSource = sql.BuscarEmpleado(obj);

            }
            else
            {

                DGVempleado.DataSource = sql.MostrarDatosEmpleado();

            }
        }

        private void btnReporteEmpleados_Click(object sender, EventArgs e)
        {
            ReporteEmpleados ver = new ReporteEmpleados();
            ver.ShowDialog();
        }

        public void limpiar()
        {

            txtIdE.Clear();
            txtNombreE.Clear();
            txtApellidoE.Clear();
            txtPasswordE.Clear();
            txtFContraE.Clear();
            txtFNaEmpleado.Clear();
            txtDireccionE.Clear();
            txtTelefonoE.Clear();
            txtUsuarioE.Clear();
            txtDuiE.Clear();
            txtCorreoE.Clear();
        }
    }

}
