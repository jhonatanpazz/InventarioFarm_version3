using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;
//using Modelo;
using Controlador;

namespace InventarioFarm_version3
{
    public partial class Login : Form
    {

        C_Empleado objeuser = new C_Empleado();
        V_Empleado objnuser = new V_Empleado();
        MenuPrincipal mn = new MenuPrincipal();

        public static string usuario_empleado;
        public static String idRol;


        

        public void login()
        {

            DataTable dt = new DataTable();
            objeuser.Usuario = txtusuario.Text;
            objeuser.Contrasena = txtpassword.Text;
            
            dt = objnuser.V_empleado(objeuser);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenid@ "+ dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_empleado = dt.Rows[0][1].ToString();
               idRol = dt.Rows[0][0].ToString();

                   MenuPrincipal main = new MenuPrincipal();
                   main.Show();
                   this.Owner = main;
                   this.Hide();

               

                /*mn.ShowDialog();

                  Login login = new Login();
                  login.ShowDialog();

                  if (login.DialogResult == DialogResult.OK)
                      Application.Run(new MenuPrincipal());

                this.Close();
                txtusuario.Clear();
                  txtpassword.Clear();
                
    */
               

            }
            else
            {
                MessageBox.Show("Usuario y password incorrectos" , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
           // this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
