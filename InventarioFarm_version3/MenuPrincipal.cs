using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace InventarioFarm_version3
{
    public partial class MenuPrincipal : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChilForm;

        
        public MenuPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            customizeDesign();

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void ActivateButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //border button

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconformularioactual.IconChar = currentBtn.IconChar;
                iconformularioactual.IconColor = color;

            }

        }

        private void DisableButton()
        {

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;


            }
        }

        private void OpenChildForm(Form childForm)
        {

            if (currentChilForm != null)
            {
                // open only form
                currentChilForm.Close();
            }
            currentChilForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(childForm);
            panelCentral.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            labeltituloform.Text = childForm.Text;
        }

        // boton desplegable

        private void customizeDesign()
        {
            panelMantos.Visible = false;

        }

        private void hidesubMenu()
        {
            if (panelMantos.Visible == true)
               panelMantos.Visible = false;

        }

       

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if(Login.idRol == "1")
            {
                btnMantos.Enabled = true;
                btnCliente.Enabled = true;
                btnEmpleado.Enabled = true;
                btnFacturar.Enabled = true;
            }
            if(Login.idRol == "2")
            {
                panelMantos.Visible = false;
                btnMantos.Visible = false;
                btnFacturar.Visible = true;
                btnCreadores.Visible = true;
                btnSalir.Visible = true;

            }

        }


        public void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconformularioactual.IconChar = IconChar.Home;
            iconformularioactual.IconColor = Color.Magenta;
            labeltituloform.Text = "Home";

        }

        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

            private void paneltitleBar(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChilForm.Close();
            Reset();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, Color.Magenta);
            OpenChildForm(new Facturar());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal nv = new MenuPrincipal();
            Login ver = new Login();
            ver.ShowDialog();
            //this.Close();
            this.Hide();
            

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Desarrolladores ne = new Desarrolladores();
            ne.Show();
        }

        

        private void btnMantos_Click_1(object sender, EventArgs e)
        {

            if (panelMantos.Visible == true)
            {
                 hidesubMenu();
                panelMantos.Visible = false;


            }
            else
            {
                panelMantos.Visible = true;
            }

        }

       

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new MantoClientes());
            ActivateButton(sender, Color.Magenta);

            hidesubMenu();
        }

        private void btnEmpleado_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Magenta);
            OpenChildForm(new MantoEmpleado());

            hidesubMenu();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Magenta);
            OpenChildForm(new MantoSucursales());

            hidesubMenu();
        }

        private void btnMantoMedicamentos_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new MantoMedicamentocs());

            ActivateButton(sender, Color.Magenta);

            hidesubMenu();
        }

        private void btnMantoMarcas_Click(object sender, EventArgs e)
        {

            OpenChildForm(new MantoMarcas());

            ActivateButton(sender, Color.Magenta);

            hidesubMenu();

        }

        private void btnMantoProveedor_Click(object sender, EventArgs e)
        {

            OpenChildForm(new MantoProveedores());

            ActivateButton(sender, Color.Magenta);

            hidesubMenu();
        }

        private void btnMantoInventario_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Manto_Inventario());

            ActivateButton(sender, Color.Magenta);

            hidesubMenu();

        }
    }
}
