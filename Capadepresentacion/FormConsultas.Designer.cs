namespace Capadepresentacion
{
    partial class FormConsultas
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panelTitulo = new Panel();
            panel2 = new Panel();
            lblTitulo = new Label();
            panelBusqueda = new Panel();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            cbEstado = new ComboBox();
            cbPais = new ComboBox();
            cbTipoPago = new ComboBox();
            lblTipoPago = new Label();
            lblPais = new Label();
            lblEstado = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtIdPasajero = new TextBox();
            lbl_IdPasajeros = new Label();
            panelDatagridPasajeros = new Panel();
            panel1 = new Panel();
            dataGridViewPagos = new DataGridView();
            dataGridViewPasajeros = new DataGridView();
            panelTitulo.SuspendLayout();
            panelBusqueda.SuspendLayout();
            panelDatagridPasajeros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasajeros).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.White;
            panelTitulo.Controls.Add(panel2);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1308, 73);
            panelTitulo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 31, 68);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(964, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 73);
            panel2.TabIndex = 11;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(104, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(74, 20);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "NOMBRE";
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.FromArgb(30, 31, 68);
            panelBusqueda.Controls.Add(btnBuscar);
            panelBusqueda.Controls.Add(btnLimpiar);
            panelBusqueda.Controls.Add(cbEstado);
            panelBusqueda.Controls.Add(cbPais);
            panelBusqueda.Controls.Add(cbTipoPago);
            panelBusqueda.Controls.Add(lblTipoPago);
            panelBusqueda.Controls.Add(lblPais);
            panelBusqueda.Controls.Add(lblEstado);
            panelBusqueda.Controls.Add(lblNombre);
            panelBusqueda.Controls.Add(txtNombre);
            panelBusqueda.Controls.Add(txtIdPasajero);
            panelBusqueda.Controls.Add(lbl_IdPasajeros);
            panelBusqueda.Dock = DockStyle.Right;
            panelBusqueda.Location = new Point(964, 73);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(344, 861);
            panelBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(22, 508);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(121, 38);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(205, 508);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(125, 38);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(46, 219);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(253, 28);
            cbEstado.TabIndex = 9;
            // 
            // cbPais
            // 
            cbPais.FormattingEnabled = true;
            cbPais.Location = new Point(46, 145);
            cbPais.Name = "cbPais";
            cbPais.Size = new Size(253, 28);
            cbPais.TabIndex = 8;
            // 
            // cbTipoPago
            // 
            cbTipoPago.FormattingEnabled = true;
            cbTipoPago.Location = new Point(46, 309);
            cbTipoPago.Name = "cbTipoPago";
            cbTipoPago.Size = new Size(253, 28);
            cbTipoPago.TabIndex = 7;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoPago.ForeColor = SystemColors.ControlLightLight;
            lblTipoPago.Location = new Point(104, 286);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(131, 20);
            lblTipoPago.TabIndex = 6;
            lblTipoPago.Text = "TIPOS DE PAGOS:";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPais.ForeColor = SystemColors.ControlLightLight;
            lblPais.Location = new Point(142, 110);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(49, 20);
            lblPais.TabIndex = 5;
            lblPais.Text = "PAIS :";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.ForeColor = SystemColors.ControlLightLight;
            lblEstado.Location = new Point(128, 196);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(78, 20);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "ESTADO  :";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(179, 7);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtIdPasajero
            // 
            txtIdPasajero.Location = new Point(22, 30);
            txtIdPasajero.Name = "txtIdPasajero";
            txtIdPasajero.Size = new Size(61, 27);
            txtIdPasajero.TabIndex = 1;
            // 
            // lbl_IdPasajeros
            // 
            lbl_IdPasajeros.AutoSize = true;
            lbl_IdPasajeros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IdPasajeros.ForeColor = SystemColors.ControlLightLight;
            lbl_IdPasajeros.Location = new Point(46, 7);
            lbl_IdPasajeros.Name = "lbl_IdPasajeros";
            lbl_IdPasajeros.Size = new Size(25, 20);
            lbl_IdPasajeros.TabIndex = 0;
            lbl_IdPasajeros.Text = "ID";
            // 
            // panelDatagridPasajeros
            // 
            panelDatagridPasajeros.Controls.Add(panel1);
            panelDatagridPasajeros.Controls.Add(dataGridViewPagos);
            panelDatagridPasajeros.Controls.Add(dataGridViewPasajeros);
            panelDatagridPasajeros.Dock = DockStyle.Top;
            panelDatagridPasajeros.Location = new Point(0, 73);
            panelDatagridPasajeros.Name = "panelDatagridPasajeros";
            panelDatagridPasajeros.Size = new Size(964, 861);
            panelDatagridPasajeros.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 436);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 43);
            panel1.TabIndex = 2;
            // 
            // dataGridViewPagos
            // 
            dataGridViewCellStyle7.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewPagos.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewPagos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewPagos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(30, 31, 68);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(148, 148, 148);
            dataGridViewCellStyle9.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewPagos.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewPagos.EnableHeadersVisualStyles = false;
            dataGridViewPagos.Location = new Point(6, 485);
            dataGridViewPagos.Name = "dataGridViewPagos";
            dataGridViewPagos.RowHeadersWidth = 51;
            dataGridViewPagos.RowTemplate.Height = 29;
            dataGridViewPagos.Size = new Size(955, 364);
            dataGridViewPagos.TabIndex = 1;
            // 
            // dataGridViewPasajeros
            // 
            dataGridViewCellStyle10.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewPasajeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewPasajeros.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewPasajeros.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewPasajeros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(30, 31, 68);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(148, 148, 148);
            dataGridViewCellStyle12.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridViewPasajeros.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewPasajeros.Dock = DockStyle.Top;
            dataGridViewPasajeros.EnableHeadersVisualStyles = false;
            dataGridViewPasajeros.Location = new Point(0, 0);
            dataGridViewPasajeros.Name = "dataGridViewPasajeros";
            dataGridViewPasajeros.RowHeadersWidth = 51;
            dataGridViewPasajeros.RowTemplate.Height = 29;
            dataGridViewPasajeros.Size = new Size(964, 436);
            dataGridViewPasajeros.TabIndex = 0;
            // 
            // FormConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 934);
            Controls.Add(panelDatagridPasajeros);
            Controls.Add(panelBusqueda);
            Controls.Add(panelTitulo);
            Name = "FormConsultas";
            Text = "CONSULTAS";
            Load += FormConsultas_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelDatagridPasajeros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPasajeros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Panel panelBusqueda;
        private Panel panelDatagridPasajeros;
        private DataGridView dataGridViewPasajeros;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtIdPasajero;
        private Label lbl_IdPasajeros;
        private ComboBox cbEstado;
        private ComboBox cbPais;
        private ComboBox cbTipoPago;
        private Label lblTipoPago;
        private Label lblPais;
        private Label lblEstado;
        private Label lblTitulo;
        private Button btnBuscar;
        private Button btnLimpiar;
        private DataGridView dataGridViewPagos;
        private Panel panel1;
        private Panel panel2;
    }
}