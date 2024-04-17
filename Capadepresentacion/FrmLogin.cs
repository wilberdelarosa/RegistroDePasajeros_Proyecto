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
           InitializeCustomComponents();
           


        }
        private void InitializeCustomComponents()
        {
            // Añade aquí la inicialización personalizada de componentes, si es necesario
            txtpassword.UseSystemPasswordChar = true; // Inicialmente no ocultar la contraseña
            txtpassword.ForeColor = Color.White; // Establece el color del texto de la contraseña.

        }
        public void ActivarBotonRegistrar()
        {
            btnregistrar.Visible = true;
            btnregistrar.Enabled = true;

            btningresar.Visible = false;
            btningresar.Enabled = false;

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
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {

            txtpassword.UseSystemPasswordChar = true;

        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                txtpassword.UseSystemPasswordChar = false;
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
            ResetearEstadoBotones();
        }
        public void ResetearEstadoBotones()
        {
            // Estado por defecto de los botones cuando el FrmLogin se carga
            btnregistrar.Visible = false;  // Ocultar el botón registrar al inicio
            btnregistrar.Enabled = false;  // Deshabilitar el botón registrar al inicio
            btningresar.Enabled = true;    // Habilitar el botón de ingresar al inicio
        }
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #region BOTON INSERTAR
        private void btningresar_Click(object sender, EventArgs e)
        {


            string username = txtusuario.Text.Trim();
            string password = txtpassword.Text.Trim();

            // Verificar que los campos no estén vacíos o tengan los valores por defecto
            if (string.IsNullOrWhiteSpace(username) || username.Equals("USUARIO", StringComparison.OrdinalIgnoreCase))
            {
                msgError("Ingrese su nombre de usuario.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(password) || password.Equals("CONTRASEÑA", StringComparison.OrdinalIgnoreCase))
            {
                msgError("Ingrese su contraseña.");
                return;
            }


            if (userLogic.IsValidUser(username, password))
            {
                // Inicio de sesión exitoso
                //MessageBox.Show($"Inicio de sesión exitoso, bienvenido usuario {username}");
                // Limpiar campos
                txtusuario.Text = "USUARIO";
                txtpassword.Text = "CONTRASEÑA";
                txtpassword.UseSystemPasswordChar = false;

                // Aca abrir el formulario principal
                FormMainMenu FormMainMenu = new FormMainMenu();
                this.Hide(); // Oculta el formulario de login
                FormMainMenu.ShowDialog();
                //this.Close();



                // Aca quí tengo que abrir el formulario principal 
            }
            else
            {
                // Error de inicio de sesión
                msgError("El usuario o la contraseña son incorrectos");



            }
        }
        #endregion

        #region BOTON REGISTRAR
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string username = txtusuario.Text;
            string password = txtpassword.Text;

            if (string.IsNullOrWhiteSpace(username) || username.Equals("USUARIO", StringComparison.OrdinalIgnoreCase))
            {
                msgError("Ingrese su nombre de usuario.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(password) || password.Equals("CONTRASEÑA", StringComparison.OrdinalIgnoreCase))
            {
                msgError("Ingrese su contraseña.");
                return;
            }

            if (userLogic.RegisterUser(username, password))
            {
                msgError($"Usuario {username} registrado exitosamente.");

                // Limpiar campos independientemente del resultado
                txtusuario.Clear();
                txtpassword.Clear();
                txtpassword.UseSystemPasswordChar = false;



            }

            else
            {
                msgError("No se pudo registrar el usuario");
            }

        }
        #endregion
        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
        private void msgError(string msg)
        {
            lblMensaje.Text = "    " + msg;
            lblMensaje.Visible = true;
        }

        private void iconPictureBoxEye_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();

        }
        private void TogglePasswordVisibility()
        {
            txtpassword.UseSystemPasswordChar = !txtpassword.UseSystemPasswordChar;
            iconPictureBoxEye.IconChar = txtpassword.UseSystemPasswordChar ? FontAwesome.Sharp.IconChar.EyeSlash : FontAwesome.Sharp.IconChar.Eye;
        }
    }

}
