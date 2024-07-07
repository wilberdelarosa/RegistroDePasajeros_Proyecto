namespace vista
{
    partial class FrmGmantenimientos
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
            tabControlMantenimiento = new TabControl();
            tabPageView = new TabPage();
            tabPageEdit = new TabPage();
            splitContainer1 = new SplitContainer();
            comboBox1 = new ComboBox();
            label1 = new Label();
            iconBusqueda = new FontAwesome.Sharp.IconPictureBox();
            panelFiltros = new Panel();
            radiobtnMinicargador = new RadioButton();
            radiobtnRetropala = new RadioButton();
            radiobtnMiniretros = new RadioButton();
            radiobtnExcavadora = new RadioButton();
            radiobtnMontacargas = new RadioButton();
            radiobtnRodillos = new RadioButton();
            radiobtnTelehandler = new RadioButton();
            radiobtnCamiones = new RadioButton();
            radiobtnPersonal = new RadioButton();
            panelbotones = new Panel();
            btnActualizarL = new Button();
            button1 = new Button();
            contextMenu = new ContextMenuStrip(components);
            radiobtnTodos = new RadioButton();
            dataGridView1 = new DataGridView();
            activo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tabControlMantenimiento.SuspendLayout();
            tabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBusqueda).BeginInit();
            panelFiltros.SuspendLayout();
            panelbotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControlMantenimiento
            // 
            tabControlMantenimiento.Controls.Add(tabPageView);
            tabControlMantenimiento.Controls.Add(tabPageEdit);
            tabControlMantenimiento.Dock = DockStyle.Fill;
            tabControlMantenimiento.Location = new Point(0, 0);
            tabControlMantenimiento.Name = "tabControlMantenimiento";
            tabControlMantenimiento.SelectedIndex = 0;
            tabControlMantenimiento.Size = new Size(1090, 450);
            tabControlMantenimiento.TabIndex = 0;
            // 
            // tabPageView
            // 
            tabPageView.Controls.Add(splitContainer1);
            tabPageView.Location = new Point(4, 29);
            tabPageView.Name = "tabPageView";
            tabPageView.Padding = new Padding(3);
            tabPageView.Size = new Size(1082, 417);
            tabPageView.TabIndex = 0;
            tabPageView.Text = "tabPage1";
            tabPageView.UseVisualStyleBackColor = true;
            // 
            // tabPageEdit
            // 
            tabPageEdit.Location = new Point(4, 29);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Padding = new Padding(3);
            tabPageEdit.Size = new Size(971, 417);
            tabPageEdit.TabIndex = 1;
            tabPageEdit.Text = "tabPage2";
            tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panelbotones);
            splitContainer1.Panel1.Controls.Add(panelFiltros);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(iconBusqueda);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1076, 411);
            splitContainer1.SplitterDistance = 129;
            splitContainer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(322, 28);
            comboBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 17);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 6;
            label1.Text = "Fichas de Equipos";
            // 
            // iconBusqueda
            // 
            iconBusqueda.BackColor = Color.Transparent;
            iconBusqueda.ForeColor = SystemColors.ActiveCaptionText;
            iconBusqueda.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconBusqueda.IconColor = SystemColors.ActiveCaptionText;
            iconBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBusqueda.IconSize = 30;
            iconBusqueda.Location = new Point(12, 12);
            iconBusqueda.Name = "iconBusqueda";
            iconBusqueda.Size = new Size(35, 30);
            iconBusqueda.TabIndex = 5;
            iconBusqueda.TabStop = false;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(radiobtnTodos);
            panelFiltros.Controls.Add(radiobtnPersonal);
            panelFiltros.Controls.Add(radiobtnCamiones);
            panelFiltros.Controls.Add(radiobtnTelehandler);
            panelFiltros.Controls.Add(radiobtnRodillos);
            panelFiltros.Controls.Add(radiobtnMontacargas);
            panelFiltros.Controls.Add(radiobtnExcavadora);
            panelFiltros.Controls.Add(radiobtnMiniretros);
            panelFiltros.Controls.Add(radiobtnRetropala);
            panelFiltros.Controls.Add(radiobtnMinicargador);
            panelFiltros.Location = new Point(540, 12);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(531, 104);
            panelFiltros.TabIndex = 8;
            // 
            // radiobtnMinicargador
            // 
            radiobtnMinicargador.AutoSize = true;
            radiobtnMinicargador.Location = new Point(3, 5);
            radiobtnMinicargador.Name = "radiobtnMinicargador";
            radiobtnMinicargador.Size = new Size(133, 24);
            radiobtnMinicargador.TabIndex = 0;
            radiobtnMinicargador.TabStop = true;
            radiobtnMinicargador.Text = "Minicargadores";
            radiobtnMinicargador.UseVisualStyleBackColor = true;
            // 
            // radiobtnRetropala
            // 
            radiobtnRetropala.AutoSize = true;
            radiobtnRetropala.Location = new Point(3, 35);
            radiobtnRetropala.Name = "radiobtnRetropala";
            radiobtnRetropala.Size = new Size(101, 24);
            radiobtnRetropala.TabIndex = 1;
            radiobtnRetropala.TabStop = true;
            radiobtnRetropala.Text = "Retropalas";
            radiobtnRetropala.UseVisualStyleBackColor = true;
            // 
            // radiobtnMiniretros
            // 
            radiobtnMiniretros.AutoSize = true;
            radiobtnMiniretros.Location = new Point(150, 9);
            radiobtnMiniretros.Name = "radiobtnMiniretros";
            radiobtnMiniretros.Size = new Size(97, 24);
            radiobtnMiniretros.TabIndex = 2;
            radiobtnMiniretros.TabStop = true;
            radiobtnMiniretros.Text = "Miniretros";
            radiobtnMiniretros.UseVisualStyleBackColor = true;
            // 
            // radiobtnExcavadora
            // 
            radiobtnExcavadora.AutoSize = true;
            radiobtnExcavadora.Location = new Point(150, 35);
            radiobtnExcavadora.Name = "radiobtnExcavadora";
            radiobtnExcavadora.Size = new Size(112, 24);
            radiobtnExcavadora.TabIndex = 3;
            radiobtnExcavadora.TabStop = true;
            radiobtnExcavadora.Text = "Excavadoras";
            radiobtnExcavadora.UseVisualStyleBackColor = true;
            // 
            // radiobtnMontacargas
            // 
            radiobtnMontacargas.AutoSize = true;
            radiobtnMontacargas.Location = new Point(150, 65);
            radiobtnMontacargas.Name = "radiobtnMontacargas";
            radiobtnMontacargas.Size = new Size(110, 24);
            radiobtnMontacargas.TabIndex = 4;
            radiobtnMontacargas.TabStop = true;
            radiobtnMontacargas.Text = "Montacarga";
            radiobtnMontacargas.UseVisualStyleBackColor = true;
            // 
            // radiobtnRodillos
            // 
            radiobtnRodillos.AutoSize = true;
            radiobtnRodillos.Location = new Point(3, 65);
            radiobtnRodillos.Name = "radiobtnRodillos";
            radiobtnRodillos.Size = new Size(84, 24);
            radiobtnRodillos.TabIndex = 5;
            radiobtnRodillos.TabStop = true;
            radiobtnRodillos.Text = "Rodillos";
            radiobtnRodillos.UseVisualStyleBackColor = true;
            // 
            // radiobtnTelehandler
            // 
            radiobtnTelehandler.AutoSize = true;
            radiobtnTelehandler.Location = new Point(280, 9);
            radiobtnTelehandler.Name = "radiobtnTelehandler";
            radiobtnTelehandler.Size = new Size(107, 24);
            radiobtnTelehandler.TabIndex = 6;
            radiobtnTelehandler.TabStop = true;
            radiobtnTelehandler.Text = "Telehandler";
            radiobtnTelehandler.UseVisualStyleBackColor = true;
            // 
            // radiobtnCamiones
            // 
            radiobtnCamiones.AutoSize = true;
            radiobtnCamiones.Location = new Point(280, 35);
            radiobtnCamiones.Name = "radiobtnCamiones";
            radiobtnCamiones.Size = new Size(95, 24);
            radiobtnCamiones.TabIndex = 7;
            radiobtnCamiones.TabStop = true;
            radiobtnCamiones.Text = "Camiones";
            radiobtnCamiones.UseVisualStyleBackColor = true;
            // 
            // radiobtnPersonal
            // 
            radiobtnPersonal.AutoSize = true;
            radiobtnPersonal.Location = new Point(280, 65);
            radiobtnPersonal.Name = "radiobtnPersonal";
            radiobtnPersonal.Size = new Size(151, 24);
            radiobtnPersonal.TabIndex = 8;
            radiobtnPersonal.TabStop = true;
            radiobtnPersonal.Text = "Vehiculos Personal";
            radiobtnPersonal.UseVisualStyleBackColor = true;
            // 
            // panelbotones
            // 
            panelbotones.Controls.Add(button1);
            panelbotones.Controls.Add(btnActualizarL);
            panelbotones.Location = new Point(12, 51);
            panelbotones.Name = "panelbotones";
            panelbotones.Size = new Size(496, 75);
            panelbotones.TabIndex = 9;
            // 
            // btnActualizarL
            // 
            btnActualizarL.Location = new Point(15, 3);
            btnActualizarL.Name = "btnActualizarL";
            btnActualizarL.Size = new Size(153, 29);
            btnActualizarL.TabIndex = 0;
            btnActualizarL.Text = "Actualizar HR/KM";
            btnActualizarL.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(190, 3);
            button1.Name = "button1";
            button1.Size = new Size(208, 29);
            button1.TabIndex = 1;
            button1.Text = "Agregar Mantenimiento";
            button1.UseVisualStyleBackColor = true;
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new Size(20, 20);
            contextMenu.Name = "contextMenu";
            contextMenu.Size = new Size(61, 4);
            contextMenu.Opening += contextMenu_Opening;
            // 
            // radiobtnTodos
            // 
            radiobtnTodos.AutoSize = true;
            radiobtnTodos.Location = new Point(444, 35);
            radiobtnTodos.Name = "radiobtnTodos";
            radiobtnTodos.Size = new Size(70, 24);
            radiobtnTodos.TabIndex = 9;
            radiobtnTodos.TabStop = true;
            radiobtnTodos.Text = "Todos";
            radiobtnTodos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { activo, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1076, 278);
            dataGridView1.TabIndex = 0;
            // 
            // activo
            // 
            activo.Frozen = true;
            activo.HeaderText = "Column1";
            activo.MinimumWidth = 6;
            activo.Name = "activo";
            activo.ReadOnly = true;
            activo.Width = 125;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // GMantenimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 450);
            Controls.Add(tabControlMantenimiento);
            Name = "GMantenimientos";
            Text = "GESTION MANTENIMIENTO";
            tabControlMantenimiento.ResumeLayout(false);
            tabPageView.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconBusqueda).EndInit();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelbotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMantenimiento;
        private TabPage tabPageView;
        private SplitContainer splitContainer1;
        private TabPage tabPageEdit;
        private Panel panelFiltros;
        private RadioButton radiobtnCamiones;
        private RadioButton radiobtnTelehandler;
        private RadioButton radiobtnRodillos;
        private RadioButton radiobtnMontacargas;
        private RadioButton radiobtnExcavadora;
        private RadioButton radiobtnMiniretros;
        private RadioButton radiobtnRetropala;
        private RadioButton radiobtnMinicargador;
        private ComboBox comboBox1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconBusqueda;
        private Panel panelbotones;
        private RadioButton radiobtnPersonal;
        private Button button1;
        private Button btnActualizarL;
        private ContextMenuStrip contextMenu;
        private RadioButton radiobtnTodos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn activo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}