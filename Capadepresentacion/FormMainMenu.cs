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

namespace Capadepresentacion
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        bool sideBar_Expand = true;


        //constructor
        public FormMainMenu()
        {

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;




        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(249, 220, 26);
            public static Color color2 = Color.FromArgb(249, 220, 26);
            public static Color color3 = Color.FromArgb(249, 220, 26);
            public static Color color4 = Color.FromArgb(249, 220, 26);
            public static Color color5 = Color.FromArgb(249, 220, 26);
            public static Color color6 = Color.FromArgb(249, 220, 26);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                iconPictureBox1.IconColor = Color.White;

            }
        }
        private FrmLogin loginForm;

        public void SetLoginForm(FrmLogin form)
        {
            loginForm = form;
        }

        // Evento FormClosed del FormMainMenu
        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Activar el botón de registro en FrmLogin
            loginForm.ActivarBotonRegistrar();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(35, 40, 45);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnpasajeros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormGestionPasajeros());
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormPagos());
        }

        private void ptnconsultas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormConsultas());
        }

        private void btnacercade_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormAcercaDe());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(249, 220, 26); 
            lblTitleChildForm.Text = "INICIO";

            iconPictureBox1.IconChar = IconChar.Home;
            iconPictureBox1.IconColor = Color.FromArgb(249, 220, 26);
        }

        //Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Aquí reutilizamos el formulario de login si ya existe, o creamos uno nuevo
            FrmLogin loginForm = Application.OpenForms.OfType<FrmLogin>().FirstOrDefault() ?? new FrmLogin();

            // Activamos el botón de registro
            loginForm.ActivarBotonRegistrar();
            //loginForm.txtpassword.Clear;
            loginForm.ClearFields();

            // Mostramos el formulario de login
            loginForm.Show();
        }

        private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
            if (sideBar_Expand)
            {
                btnpasajeros.Text = ""; // Hide text
                btnpagos.Text = "";
                ptnconsultas.Text = "";
                btnacercade.Text = "";
                btnRegistrar.Text = "";


                panelMenu.Width -= 120; // Aumentar la velocidad
                if (panelMenu.Width <= panelMenu.MinimumSize.Width)
                {
                    sideBar_Expand = false;

                    Timer_Sidebar_Menu.Stop();
                    AdjustMenuItems();

                    // Adjust visibility of text when collapsed
                }
            }
            else
            {

                panelMenu.Width += 120; // Aumentar la velocidad
                if (panelMenu.Width >= panelMenu.MaximumSize.Width)
                {
                    sideBar_Expand = true;


                    Timer_Sidebar_Menu.Stop();
                    AdjustMenuItems();

                    // Adjust visibility of text when expanded
                }
            }
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();

        }
        private void AdjustMenuItems()
        {
            foreach (IconButton button in panelMenu.Controls.OfType<IconButton>())
            {
                if (sideBar_Expand)
                {
                    btnpasajeros.Text = btnpasajeros.Tag.ToString();
                    btnpagos.Text = btnpagos.Tag.ToString();
                    ptnconsultas.Text = ptnconsultas.Tag.ToString();
                    btnacercade.Text = btnacercade.Tag.ToString();
                    btnRegistrar.Text = btnRegistrar.Tag.ToString();


                    Menu_Button.ForeColor = Color.White;

                    // Show text
                }
                else
                {
                    btnpasajeros.Text = ""; // Hide text
                    btnpagos.Text = "";
                    ptnconsultas.Text = "";
                    btnacercade.Text = "";
                    btnRegistrar.Text = "";

                    Menu_Button.ForeColor = Color.Yellow;


                }
            }
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
    }
}

