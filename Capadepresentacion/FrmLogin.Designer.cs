namespace Capadepresentacion
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtusuario = new TextBox();
            txtpassword = new TextBox();
            btningresar = new Button();
            lbltitulo = new Label();
            btnregistrar = new Button();
            Exit = new PictureBox();
            minimizar = new PictureBox();
            lblMensaje = new Label();
            iconPictureBoxEye = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            lblcontraseña = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxEye).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 357);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO010;
            pictureBox1.Location = new Point(46, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            txtusuario.BackColor = Color.FromArgb(15, 15, 15);
            txtusuario.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.ForeColor = Color.White;
            txtusuario.Location = new Point(341, 97);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(365, 28);
            txtusuario.TabIndex = 1;
            txtusuario.Enter += txtusuario_Enter;
            txtusuario.Leave += txtusuario_Leave;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(15, 15, 15);
            txtpassword.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.DimGray;
            txtpassword.Location = new Point(341, 173);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(365, 26);
            txtpassword.TabIndex = 2;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.Enter += txtpassword_Enter;
            txtpassword.Leave += txtpassword_Leave;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.FromArgb(40, 40, 40);
            btningresar.FlatAppearance.BorderSize = 0;
            btningresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btningresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btningresar.FlatStyle = FlatStyle.Flat;
            btningresar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btningresar.ForeColor = SystemColors.ControlLight;
            btningresar.Location = new Point(341, 248);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(365, 30);
            btningresar.TabIndex = 3;
            btningresar.Text = "INGRESAR";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitulo.ForeColor = Color.DimGray;
            lbltitulo.Location = new Point(460, 6);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(100, 33);
            lbltitulo.TabIndex = 4;
            lbltitulo.Text = "LOGIN";
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.FromArgb(40, 40, 40);
            btnregistrar.FlatAppearance.BorderSize = 0;
            btnregistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnregistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnregistrar.FlatStyle = FlatStyle.Flat;
            btnregistrar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnregistrar.ForeColor = SystemColors.ControlLight;
            btnregistrar.Location = new Point(341, 294);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(365, 29);
            btnregistrar.TabIndex = 5;
            btnregistrar.Text = "REGISTRAR";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // Exit
            // 
            Exit.Image = Properties.Resources.SALIR;
            Exit.Location = new Point(736, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(32, 30);
            Exit.SizeMode = PictureBoxSizeMode.StretchImage;
            Exit.TabIndex = 6;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // minimizar
            // 
            minimizar.Image = Properties.Resources.minimizar2;
            minimizar.Location = new Point(690, 0);
            minimizar.Name = "minimizar";
            minimizar.Size = new Size(30, 30);
            minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            minimizar.TabIndex = 7;
            minimizar.TabStop = false;
            minimizar.Click += minimizar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("MS Reference Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.OrangeRed;
            lblMensaje.Image = Properties.Resources.MaterialSymbolsLightErrorOutlineRounded__3_;
            lblMensaje.ImageAlign = ContentAlignment.MiddleLeft;
            lblMensaje.Location = new Point(341, 213);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(138, 16);
            lblMensaje.TabIndex = 8;
            lblMensaje.Text = "    Mensaje de error";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Visible = false;
            lblMensaje.Click += lblMensaje_Click;
            // 
            // iconPictureBoxEye
            // 
            iconPictureBoxEye.BackColor = Color.Transparent;
            iconPictureBoxEye.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBoxEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconPictureBoxEye.IconColor = SystemColors.ButtonHighlight;
            iconPictureBoxEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBoxEye.IconSize = 26;
            iconPictureBoxEye.Location = new Point(712, 173);
            iconPictureBoxEye.Name = "iconPictureBoxEye";
            iconPictureBoxEye.Size = new Size(39, 26);
            iconPictureBoxEye.TabIndex = 9;
            iconPictureBoxEye.TabStop = false;
            iconPictureBoxEye.Click += iconPictureBoxEye_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(475, 86);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 10;
            label1.Text = "USUARIO";
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblcontraseña.ForeColor = Color.DimGray;
            lblcontraseña.Location = new Point(460, 162);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(107, 20);
            lblcontraseña.TabIndex = 11;
            lblcontraseña.Text = "CONTRASEÑA";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 357);
            Controls.Add(lblcontraseña);
            Controls.Add(label1);
            Controls.Add(iconPictureBoxEye);
            Controls.Add(lblMensaje);
            Controls.Add(minimizar);
            Controls.Add(Exit);
            Controls.Add(btnregistrar);
            Controls.Add(lbltitulo);
            Controls.Add(btningresar);
            Controls.Add(txtpassword);
            Controls.Add(txtusuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            FormClosing += FrmLogin_FormClosing;
            Load += FrmLogin_Load;
            MouseDown += FrmLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtusuario;
        private TextBox txtpassword;
        private Button btningresar;
        private Label lbltitulo;
        private PictureBox pictureBox1;
        private Button btnregistrar;
        private PictureBox Exit;
        private PictureBox minimizar;
        private Label lblMensaje;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxEye;
        private Label label1;
        private Label lblcontraseña;
    }
}