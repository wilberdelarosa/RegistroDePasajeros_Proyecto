using Capadedatos;
using capadenegocio;
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

namespace Capadepresentacion
{
    public partial class FrmLogin : Form
    {
        private CN_UserLogic userLogic = new CN_UserLogic();

        #region MOVER FORM 

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public FrmLogin()
        {
            InitializeComponent();


        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;

            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "CONTRASEÑA")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;

            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "CONTRASEÑA";
                txtpassword.ForeColor = Color.DimGray;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {


            string username = txtusuario.Text.Trim();
            string password = txtpassword.Text.Trim();

            // Verificar que los campos no estén vacíos o tengan los valores por defecto
            if (string.IsNullOrWhiteSpace(username) || username.Equals("USUARIO", StringComparison.OrdinalIgnoreCase))
            {
                lblMensaje.Text = "Ingrese su nombre de usuario.";
                return;
            }
            else if (string.IsNullOrWhiteSpace(password) || password.Equals("CONTRASEÑA", StringComparison.OrdinalIgnoreCase))
            {
                lblMensaje.Text = "Ingrese su contraseña.";
                return;
            }


            if (userLogic.IsValidUser(username, password))
            {
                // Inicio de sesión exitoso
                MessageBox.Show($"Inicio de sesión exitoso, bienvenido usuario {username}");
                // Limpiar campos
                txtusuario.Text = "USUARIO";
                txtpassword.Text = "CONTRASEÑA";
                txtpassword.UseSystemPasswordChar = false;



                // Aca quí tengo que abrir el formulario principal 
            }
            else
            {
                // Error de inicio de sesión
                lblMensaje.Text = ("El usuario o la contraseña son incorrectos");
                // Limpiar campos
                txtusuario.Text = "USUARIO";
                txtpassword.Text = "CONTRASEÑA";
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string username = txtusuario.Text;
            string password = txtpassword.Text;

            if (string.IsNullOrWhiteSpace(username) || username.Equals("USUARIO", StringComparison.OrdinalIgnoreCase))
            {
                lblMensaje.Text = "Ingrese su nombre de usuario.";
                return;
            }
            else if (string.IsNullOrWhiteSpace(password) || password.Equals("CONTRASEÑA", StringComparison.OrdinalIgnoreCase))
            {
                lblMensaje.Text = "Ingrese su contraseña.";
                return;
            }

            if (userLogic.RegisterUser(username, password))
            {
                lblMensaje.Text = ($"Se registró exitosamente el usuario {username} ");
            }
            else
            {
                lblMensaje.Text = ("No se pudo registrar el usuario");
            }
            // Limpiar campos independientemente del resultado
            txtusuario.Clear();
            txtpassword.Clear();
            txtpassword.UseSystemPasswordChar = false;
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }

}
