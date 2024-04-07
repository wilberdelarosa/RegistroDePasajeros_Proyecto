namespace Capadepresentacion
{
    partial class FormGestionPasajeros
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
            TcPasajero = new TabControl();
            tabPagePasajeros = new TabPage();
            panelDtaGrid = new Panel();
            dataGridViewPasajero = new DataGridView();
            panelBotones = new Panel();
            btnBuscarPasajero = new Button();
            txtBuscarPasajero = new TextBox();
            btnAgregarPasajero = new Button();
            btnEditarPasajero = new Button();
            btnEliminarPasajero = new Button();
            tabAñadirPasajeros = new TabPage();
            lblTituloFormulario = new Label();
            txtFechaNacimiento = new TextBox();
            BtnCancelar = new Button();
            btnGuardar = new Button();
            lblnumerodoc = new Label();
            txtNumeroDocumento = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            cmbTipoDocumento = new ComboBox();
            lblFechaNacimiento = new Label();
            lbltipodoc = new Label();
            lblApellido = new Label();
            txtApellidoPasajero = new TextBox();
            cmbPais = new ComboBox();
            lblPais = new Label();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblNombre = new Label();
            txtNombrePasajero = new TextBox();
            TcPasajero.SuspendLayout();
            tabPagePasajeros.SuspendLayout();
            panelDtaGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasajero).BeginInit();
            panelBotones.SuspendLayout();
            tabAñadirPasajeros.SuspendLayout();
            SuspendLayout();
            // 
            // TcPasajero
            // 
            TcPasajero.Controls.Add(tabPagePasajeros);
            TcPasajero.Controls.Add(tabAñadirPasajeros);
            TcPasajero.Dock = DockStyle.Fill;
            TcPasajero.Location = new Point(0, 0);
            TcPasajero.Name = "TcPasajero";
            TcPasajero.SelectedIndex = 0;
            TcPasajero.Size = new Size(1299, 876);
            TcPasajero.TabIndex = 0;
            // 
            // tabPagePasajeros
            // 
            tabPagePasajeros.BackColor = Color.White;
            tabPagePasajeros.Controls.Add(panelDtaGrid);
            tabPagePasajeros.Controls.Add(panelBotones);
            tabPagePasajeros.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPagePasajeros.ForeColor = Color.MidnightBlue;
            tabPagePasajeros.Location = new Point(4, 29);
            tabPagePasajeros.Name = "tabPagePasajeros";
            tabPagePasajeros.Padding = new Padding(3);
            tabPagePasajeros.Size = new Size(1291, 843);
            tabPagePasajeros.TabIndex = 0;
            tabPagePasajeros.Text = "Pasajeros";
            // 
            // panelDtaGrid
            // 
            panelDtaGrid.Controls.Add(dataGridViewPasajero);
            panelDtaGrid.Dock = DockStyle.Fill;
            panelDtaGrid.Location = new Point(3, 159);
            panelDtaGrid.Name = "panelDtaGrid";
            panelDtaGrid.Size = new Size(1285, 681);
            panelDtaGrid.TabIndex = 7;
            // 
            // dataGridViewPasajero
            // 
            dataGridViewPasajero.BackgroundColor = Color.White;
            dataGridViewPasajero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPasajero.Dock = DockStyle.Fill;
            dataGridViewPasajero.Location = new Point(0, 0);
            dataGridViewPasajero.Name = "dataGridViewPasajero";
            dataGridViewPasajero.RowHeadersWidth = 51;
            dataGridViewPasajero.RowTemplate.Height = 29;
            dataGridViewPasajero.Size = new Size(1285, 681);
            dataGridViewPasajero.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnBuscarPasajero);
            panelBotones.Controls.Add(txtBuscarPasajero);
            panelBotones.Controls.Add(btnAgregarPasajero);
            panelBotones.Controls.Add(btnEditarPasajero);
            panelBotones.Controls.Add(btnEliminarPasajero);
            panelBotones.Dock = DockStyle.Top;
            panelBotones.Location = new Point(3, 3);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1285, 156);
            panelBotones.TabIndex = 6;
            // 
            // btnBuscarPasajero
            // 
            btnBuscarPasajero.Anchor = AnchorStyles.Top;
            btnBuscarPasajero.FlatAppearance.BorderSize = 2;
            btnBuscarPasajero.Location = new Point(303, 19);
            btnBuscarPasajero.Name = "btnBuscarPasajero";
            btnBuscarPasajero.Size = new Size(94, 29);
            btnBuscarPasajero.TabIndex = 2;
            btnBuscarPasajero.Text = "Buscar";
            btnBuscarPasajero.UseVisualStyleBackColor = true;
            btnBuscarPasajero.Click += btnBuscarPasajero_Click;
            // 
            // txtBuscarPasajero
            // 
            txtBuscarPasajero.Anchor = AnchorStyles.Top;
            txtBuscarPasajero.Location = new Point(421, 19);
            txtBuscarPasajero.Name = "txtBuscarPasajero";
            txtBuscarPasajero.Size = new Size(305, 25);
            txtBuscarPasajero.TabIndex = 1;
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.Anchor = AnchorStyles.Top;
            btnAgregarPasajero.FlatAppearance.BorderSize = 2;
            btnAgregarPasajero.Location = new Point(290, 87);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(149, 29);
            btnAgregarPasajero.TabIndex = 3;
            btnAgregarPasajero.Text = "Añadir nuevo";
            btnAgregarPasajero.UseVisualStyleBackColor = true;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // btnEditarPasajero
            // 
            btnEditarPasajero.Anchor = AnchorStyles.Top;
            btnEditarPasajero.FlatAppearance.BorderSize = 2;
            btnEditarPasajero.Location = new Point(466, 87);
            btnEditarPasajero.Name = "btnEditarPasajero";
            btnEditarPasajero.Size = new Size(126, 29);
            btnEditarPasajero.TabIndex = 5;
            btnEditarPasajero.Text = "Editar";
            btnEditarPasajero.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPasajero
            // 
            btnEliminarPasajero.Anchor = AnchorStyles.Top;
            btnEliminarPasajero.FlatAppearance.BorderSize = 2;
            btnEliminarPasajero.Location = new Point(640, 87);
            btnEliminarPasajero.Name = "btnEliminarPasajero";
            btnEliminarPasajero.Size = new Size(128, 29);
            btnEliminarPasajero.TabIndex = 4;
            btnEliminarPasajero.Text = "Borrar";
            btnEliminarPasajero.UseVisualStyleBackColor = true;
            // 
            // tabAñadirPasajeros
            // 
            tabAñadirPasajeros.Controls.Add(lblTituloFormulario);
            tabAñadirPasajeros.Controls.Add(txtFechaNacimiento);
            tabAñadirPasajeros.Controls.Add(BtnCancelar);
            tabAñadirPasajeros.Controls.Add(btnGuardar);
            tabAñadirPasajeros.Controls.Add(lblnumerodoc);
            tabAñadirPasajeros.Controls.Add(txtNumeroDocumento);
            tabAñadirPasajeros.Controls.Add(lblEmail);
            tabAñadirPasajeros.Controls.Add(txtEmail);
            tabAñadirPasajeros.Controls.Add(cmbTipoDocumento);
            tabAñadirPasajeros.Controls.Add(lblFechaNacimiento);
            tabAñadirPasajeros.Controls.Add(lbltipodoc);
            tabAñadirPasajeros.Controls.Add(lblApellido);
            tabAñadirPasajeros.Controls.Add(txtApellidoPasajero);
            tabAñadirPasajeros.Controls.Add(cmbPais);
            tabAñadirPasajeros.Controls.Add(lblPais);
            tabAñadirPasajeros.Controls.Add(lblTelefono);
            tabAñadirPasajeros.Controls.Add(txtTelefono);
            tabAñadirPasajeros.Controls.Add(lblNombre);
            tabAñadirPasajeros.Controls.Add(txtNombrePasajero);
            tabAñadirPasajeros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabAñadirPasajeros.Location = new Point(4, 29);
            tabAñadirPasajeros.Name = "tabAñadirPasajeros";
            tabAñadirPasajeros.Padding = new Padding(3);
            tabAñadirPasajeros.Size = new Size(1291, 843);
            tabAñadirPasajeros.TabIndex = 1;
            tabAñadirPasajeros.Text = "Añadir pasajeros";
            tabAñadirPasajeros.UseVisualStyleBackColor = true;
            // 
            // lblTituloFormulario
            // 
            lblTituloFormulario.AutoSize = true;
            lblTituloFormulario.Location = new Point(389, 22);
            lblTituloFormulario.Name = "lblTituloFormulario";
            lblTituloFormulario.Size = new Size(71, 20);
            lblTituloFormulario.TabIndex = 21;
            lblTituloFormulario.Text = "Nombre ";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(701, 260);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(250, 27);
            txtFechaNacimiento.TabIndex = 20;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(552, 374);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(94, 29);
            BtnCancelar.TabIndex = 19;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(339, 374);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblnumerodoc
            // 
            lblnumerodoc.AutoSize = true;
            lblnumerodoc.Location = new Point(46, 263);
            lblnumerodoc.Name = "lblnumerodoc";
            lblnumerodoc.Size = new Size(174, 20);
            lblnumerodoc.TabIndex = 17;
            lblnumerodoc.Text = "Número de Documento";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(241, 260);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(250, 27);
            txtNumeroDocumento.TabIndex = 16;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(552, 91);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(609, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 27);
            txtEmail.TabIndex = 12;
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Location = new Point(205, 201);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(183, 28);
            cmbTipoDocumento.TabIndex = 11;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(540, 265);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(155, 20);
            lblFechaNacimiento.TabIndex = 10;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lbltipodoc
            // 
            lbltipodoc.AutoSize = true;
            lbltipodoc.Location = new Point(52, 204);
            lbltipodoc.Name = "lbltipodoc";
            lbltipodoc.Size = new Size(147, 20);
            lbltipodoc.TabIndex = 9;
            lbltipodoc.Text = "Tipo de Documento";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(61, 147);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(71, 20);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido ";
            // 
            // txtApellidoPasajero
            // 
            txtApellidoPasajero.Location = new Point(138, 147);
            txtApellidoPasajero.Name = "txtApellidoPasajero";
            txtApellidoPasajero.Size = new Size(250, 27);
            txtApellidoPasajero.TabIndex = 6;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(609, 147);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(284, 28);
            cmbPais.TabIndex = 5;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(552, 147);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(37, 20);
            lblPais.TabIndex = 4;
            lblPais.Text = "País";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(540, 204);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(643, 197);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 27);
            txtTelefono.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(61, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre ";
            // 
            // txtNombrePasajero
            // 
            txtNombrePasajero.Location = new Point(138, 88);
            txtNombrePasajero.Name = "txtNombrePasajero";
            txtNombrePasajero.Size = new Size(250, 27);
            txtNombrePasajero.TabIndex = 0;
            // 
            // FormGestionPasajeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 876);
            Controls.Add(TcPasajero);
            Name = "FormGestionPasajeros";
            Text = "Gestion de pasajeros";
            Load += FormGestionPasajeros_Load;
            TcPasajero.ResumeLayout(false);
            tabPagePasajeros.ResumeLayout(false);
            panelDtaGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasajero).EndInit();
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            tabAñadirPasajeros.ResumeLayout(false);
            tabAñadirPasajeros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TcPasajero;
        private TabPage tabPagePasajeros;
        private TabPage tabAñadirPasajeros;
        private Button btnBuscarPasajero;
        private TextBox txtBuscarPasajero;
        private DataGridView dataGridViewPasajero;
        private Button btnEditarPasajero;
        private Button btnEliminarPasajero;
        private Button btnAgregarPasajero;
        private Label lblEmail;
        private TextBox txtEmail;
        private ComboBox cmbTipoDocumento;
        private Label lblFechaNacimiento;
        private Label lbltipodoc;
        private Label lblApellido;
        private TextBox txtApellidoPasajero;
        private ComboBox cmbPais;
        private Label lblPais;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblNombre;
        private TextBox txtNombrePasajero;
        private Button btnGuardar;
        private Label lblnumerodoc;
        private TextBox txtNumeroDocumento;
        private Button BtnCancelar;
        private TextBox txtFechaNacimiento;
        private Panel panelDtaGrid;
        private Panel panelBotones;
        private Label lblTituloFormulario;
    }
}