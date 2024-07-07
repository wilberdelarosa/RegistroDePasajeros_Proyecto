namespace Capadepresentacion
{
    partial class FormMainMenu
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
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            btnacercade = new FontAwesome.Sharp.IconButton();
            ptnconsultas = new FontAwesome.Sharp.IconButton();
            btnpagos = new FontAwesome.Sharp.IconButton();
            btnpasajeros = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            Menu_Button = new FontAwesome.Sharp.IconPictureBox();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            btnClose = new FontAwesome.Sharp.IconPictureBox();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            panel2 = new Panel();
            panelDesktop = new Panel();
            Timer_Sidebar_Menu = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Menu_Button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(35, 40, 45);
            panelMenu.Controls.Add(btnRegistrar);
            panelMenu.Controls.Add(btnacercade);
            panelMenu.Controls.Add(ptnconsultas);
            panelMenu.Controls.Add(btnpagos);
            panelMenu.Controls.Add(btnpasajeros);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.MaximumSize = new Size(248, 853);
            panelMenu.MinimumSize = new Size(70, 678);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(248, 853);
            panelMenu.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Dock = DockStyle.Top;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            btnRegistrar.IconColor = Color.White;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnRegistrar.IconSize = 35;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(0, 439);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(248, 60);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Tag = "Acerca de sistema";
            btnRegistrar.Text = "Acerca de sistema";
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnacercade
            // 
            btnacercade.Dock = DockStyle.Top;
            btnacercade.FlatAppearance.BorderSize = 0;
            btnacercade.FlatStyle = FlatStyle.Flat;
            btnacercade.ForeColor = SystemColors.ButtonFace;
            btnacercade.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnacercade.IconColor = Color.White;
            btnacercade.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnacercade.IconSize = 35;
            btnacercade.ImageAlign = ContentAlignment.MiddleLeft;
            btnacercade.Location = new Point(0, 379);
            btnacercade.Name = "btnacercade";
            btnacercade.Size = new Size(248, 60);
            btnacercade.TabIndex = 4;
            btnacercade.Tag = "Control Equipos";
            btnacercade.Text = "Control Equipos";
            btnacercade.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnacercade.UseVisualStyleBackColor = true;
            btnacercade.Click += btnacercade_Click;
            // 
            // ptnconsultas
            // 
            ptnconsultas.Dock = DockStyle.Top;
            ptnconsultas.FlatAppearance.BorderSize = 0;
            ptnconsultas.FlatStyle = FlatStyle.Flat;
            ptnconsultas.ForeColor = SystemColors.ButtonFace;
            ptnconsultas.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            ptnconsultas.IconColor = Color.White;
            ptnconsultas.IconFont = FontAwesome.Sharp.IconFont.Regular;
            ptnconsultas.IconSize = 35;
            ptnconsultas.ImageAlign = ContentAlignment.MiddleLeft;
            ptnconsultas.Location = new Point(0, 319);
            ptnconsultas.Name = "ptnconsultas";
            ptnconsultas.Size = new Size(248, 60);
            ptnconsultas.TabIndex = 3;
            ptnconsultas.Tag = "Control de empleado";
            ptnconsultas.Text = "Control de empleado";
            ptnconsultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            ptnconsultas.UseVisualStyleBackColor = true;
            ptnconsultas.Click += ptnconsultas_Click;
            // 
            // btnpagos
            // 
            btnpagos.Dock = DockStyle.Top;
            btnpagos.FlatAppearance.BorderSize = 0;
            btnpagos.FlatStyle = FlatStyle.Flat;
            btnpagos.ForeColor = SystemColors.ButtonFace;
            btnpagos.IconChar = FontAwesome.Sharp.IconChar.Elevator;
            btnpagos.IconColor = Color.White;
            btnpagos.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnpagos.IconSize = 38;
            btnpagos.ImageAlign = ContentAlignment.MiddleLeft;
            btnpagos.Location = new Point(0, 259);
            btnpagos.Name = "btnpagos";
            btnpagos.Size = new Size(248, 60);
            btnpagos.TabIndex = 2;
            btnpagos.Tag = "Historial";
            btnpagos.Text = "Historial";
            btnpagos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnpagos.UseVisualStyleBackColor = true;
            btnpagos.Click += btnpagos_Click;
            // 
            // btnpasajeros
            // 
            btnpasajeros.Dock = DockStyle.Top;
            btnpasajeros.FlatAppearance.BorderSize = 0;
            btnpasajeros.FlatStyle = FlatStyle.Flat;
            btnpasajeros.ForeColor = SystemColors.ButtonFace;
            btnpasajeros.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            btnpasajeros.IconColor = Color.White;
            btnpasajeros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnpasajeros.IconSize = 38;
            btnpasajeros.ImageAlign = ContentAlignment.MiddleLeft;
            btnpasajeros.Location = new Point(0, 199);
            btnpasajeros.Name = "btnpasajeros";
            btnpasajeros.Size = new Size(248, 60);
            btnpasajeros.TabIndex = 1;
            btnpasajeros.Tag = "Control de mantenimiento";
            btnpasajeros.Text = "Control de mantenimiento";
            btnpasajeros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnpasajeros.UseVisualStyleBackColor = true;
            btnpasajeros.Click += btnpasajeros_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(Menu_Button);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 199);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconPictureBox1.IconColor = SystemColors.ButtonHighlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(12, 30);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // Menu_Button
            // 
            Menu_Button.BackColor = Color.Transparent;
            Menu_Button.ForeColor = SystemColors.ButtonHighlight;
            Menu_Button.IconChar = FontAwesome.Sharp.IconChar.Equals;
            Menu_Button.IconColor = SystemColors.ButtonHighlight;
            Menu_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Menu_Button.IconSize = 40;
            Menu_Button.Location = new Point(12, 80);
            Menu_Button.Name = "Menu_Button";
            Menu_Button.Size = new Size(40, 40);
            Menu_Button.TabIndex = 5;
            Menu_Button.TabStop = false;
            Menu_Button.Click += Menu_Button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = vista.Properties.Resources.logo_AlitoEIRL;
            pictureBox1.Location = new Point(69, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(35, 40, 45);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(248, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(984, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnClose.IconColor = SystemColors.ButtonHighlight;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 30;
            btnClose.Location = new Point(942, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 40);
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.Transparent;
            iconCurrentChildForm.ForeColor = SystemColors.ButtonHighlight;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChildForm.IconColor = SystemColors.ButtonHighlight;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 40;
            iconCurrentChildForm.Location = new Point(15, 21);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(40, 40);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            iconCurrentChildForm.Click += iconCurrentChildForm_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.ForeColor = SystemColors.ButtonHighlight;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            btnMaximize.IconColor = SystemColors.ButtonHighlight;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 28;
            btnMaximize.Location = new Point(908, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(28, 40);
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.ForeColor = SystemColors.ButtonHighlight;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = SystemColors.ButtonHighlight;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 28;
            btnMinimize.Location = new Point(874, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(28, 38);
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = SystemColors.ButtonHighlight;
            lblTitleChildForm.Location = new Point(74, 30);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(52, 20);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "INICIO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(248, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 9);
            panel2.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(248, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(984, 769);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // Timer_Sidebar_Menu
            // 
            Timer_Sidebar_Menu.Interval = 40;
            Timer_Sidebar_Menu.Tick += Timer_Sidebar_Menu_Tick;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1232, 853);
            Controls.Add(panelDesktop);
            Controls.Add(panel2);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            Text = "MENU PRINCIPAL";
            Load += FormMainMenu_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Menu_Button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnpasajeros;
        private FontAwesome.Sharp.IconButton btnacercade;
        private FontAwesome.Sharp.IconButton ptnconsultas;
        private FontAwesome.Sharp.IconButton btnpagos;
        private PictureBox pictureBox1;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panel2;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.Timer Timer_Sidebar_Menu;
        private FontAwesome.Sharp.IconPictureBox Menu_Button;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}