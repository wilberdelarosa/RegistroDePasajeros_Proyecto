namespace Capadepresentacion
{
    partial class FormPagos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControlPago = new TabControl();
            tabPagepagos = new TabPage();
            dataGridViewPagos = new DataGridView();
            panel1 = new Panel();
            txtBuscarPago = new TextBox();
            btnReembolso = new Button();
            btnEditar = new Button();
            btnAñadirPago = new Button();
            btnBuscar = new Button();
            tabPageAgregarPagos = new TabPage();
            panel4 = new Panel();
            btnGuardar = new Button();
            txtFecha = new TextBox();
            btnCancelar = new Button();
            lblTitulo = new Label();
            label3 = new Label();
            txtPasajero = new ComboBox();
            label5 = new Label();
            txtMonto = new TextBox();
            label4 = new Label();
            cbTipoPagos = new ComboBox();
            label7 = new Label();
            txtImpuesto = new TextBox();
            label6 = new Label();
            txtTotal = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            tabControlPago.SuspendLayout();
            tabPagepagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).BeginInit();
            panel1.SuspendLayout();
            tabPageAgregarPagos.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPago
            // 
            tabControlPago.Controls.Add(tabPagepagos);
            tabControlPago.Controls.Add(tabPageAgregarPagos);
            tabControlPago.Dock = DockStyle.Fill;
            tabControlPago.Location = new Point(0, 0);
            tabControlPago.Name = "tabControlPago";
            tabControlPago.SelectedIndex = 0;
            tabControlPago.Size = new Size(1461, 853);
            tabControlPago.TabIndex = 0;
            // 
            // tabPagepagos
            // 
            tabPagepagos.Controls.Add(dataGridViewPagos);
            tabPagepagos.Controls.Add(panel1);
            tabPagepagos.Location = new Point(4, 26);
            tabPagepagos.Name = "tabPagepagos";
            tabPagepagos.Padding = new Padding(3);
            tabPagepagos.Size = new Size(1453, 752);
            tabPagepagos.TabIndex = 0;
            tabPagepagos.Text = "Pagos";
            tabPagepagos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPagos
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPagos.BackgroundColor = SystemColors.Window;
            dataGridViewPagos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewPagos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 31, 68);
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(148, 148, 148);
            dataGridViewCellStyle3.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewPagos.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPagos.Dock = DockStyle.Fill;
            dataGridViewPagos.EnableHeadersVisualStyles = false;
            dataGridViewPagos.Location = new Point(3, 136);
            dataGridViewPagos.Name = "dataGridViewPagos";
            dataGridViewPagos.RowHeadersWidth = 51;
            dataGridViewPagos.RowTemplate.Height = 29;
            dataGridViewPagos.Size = new Size(1447, 613);
            dataGridViewPagos.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBuscarPago);
            panel1.Controls.Add(btnReembolso);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAñadirPago);
            panel1.Controls.Add(btnBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1447, 133);
            panel1.TabIndex = 0;
            // 
            // txtBuscarPago
            // 
            txtBuscarPago.Location = new Point(379, 28);
            txtBuscarPago.Name = "txtBuscarPago";
            txtBuscarPago.Size = new Size(389, 25);
            txtBuscarPago.TabIndex = 4;
            txtBuscarPago.KeyUp += txtBuscarPago_KeyUp;
            // 
            // btnReembolso
            // 
            btnReembolso.Location = new Point(619, 78);
            btnReembolso.Name = "btnReembolso";
            btnReembolso.Size = new Size(149, 25);
            btnReembolso.TabIndex = 3;
            btnReembolso.Text = "Reembolso";
            btnReembolso.UseVisualStyleBackColor = true;
            btnReembolso.Click += btnReembolso_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(426, 78);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 25);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAñadirPago
            // 
            btnAñadirPago.Location = new Point(235, 78);
            btnAñadirPago.Name = "btnAñadirPago";
            btnAñadirPago.Size = new Size(149, 25);
            btnAñadirPago.TabIndex = 1;
            btnAñadirPago.Text = "Añadir nuevo";
            btnAñadirPago.UseVisualStyleBackColor = true;
            btnAñadirPago.Click += btnAñadirPago_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(235, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(106, 25);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tabPageAgregarPagos
            // 
            tabPageAgregarPagos.BackColor = Color.White;
            tabPageAgregarPagos.Controls.Add(panel4);
            tabPageAgregarPagos.Controls.Add(panel3);
            tabPageAgregarPagos.Controls.Add(panel2);
            tabPageAgregarPagos.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tabPageAgregarPagos.ForeColor = Color.Black;
            tabPageAgregarPagos.Location = new Point(4, 26);
            tabPageAgregarPagos.Name = "tabPageAgregarPagos";
            tabPageAgregarPagos.Padding = new Padding(3);
            tabPageAgregarPagos.Size = new Size(1453, 823);
            tabPageAgregarPagos.TabIndex = 1;
            tabPageAgregarPagos.Text = "Agregar Pagos";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(txtFecha);
            panel4.Controls.Add(btnCancelar);
            panel4.Controls.Add(lblTitulo);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtPasajero);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtMonto);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(cbTipoPagos);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtImpuesto);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtTotal);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(253, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(868, 817);
            panel4.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(57, 163, 105);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(286, 584);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 36);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(286, 123);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(339, 28);
            txtFecha.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(504, 584);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 36);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(26, 25, 62);
            lblTitulo.Location = new Point(314, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 38);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "AGREGAR PAGOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(157, 201);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 4;
            label3.Text = "Pasajero :";
            // 
            // txtPasajero
            // 
            txtPasajero.FormattingEnabled = true;
            txtPasajero.Location = new Point(286, 196);
            txtPasajero.Name = "txtPasajero";
            txtPasajero.Size = new Size(339, 31);
            txtPasajero.TabIndex = 16;
            txtPasajero.SelectedIndexChanged += txtPasajero_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(158, 276);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 7;
            label5.Text = "Monto :";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(286, 268);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(339, 28);
            txtMonto.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(152, 348);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 8;
            label4.Text = "Tipo de pago";
            // 
            // cbTipoPagos
            // 
            cbTipoPagos.FormattingEnabled = true;
            cbTipoPagos.Location = new Point(286, 338);
            cbTipoPagos.Name = "cbTipoPagos";
            cbTipoPagos.Size = new Size(339, 31);
            cbTipoPagos.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(152, 420);
            label7.Name = "label7";
            label7.Size = new Size(86, 23);
            label7.TabIndex = 11;
            label7.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(286, 412);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(339, 28);
            txtImpuesto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(152, 488);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 12;
            label6.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(286, 478);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(339, 28);
            txtTotal.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(158, 128);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 3;
            label2.Text = "Fecha :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 25, 62);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1121, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 817);
            panel3.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 25, 62);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 817);
            panel2.TabIndex = 17;
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 853);
            Controls.Add(tabControlPago);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.MidnightBlue;
            Name = "FormPagos";
            Text = "FormPagos";
            Load += FormPagos_Load;
            KeyUp += FormPagos_KeyUp;
            tabControlPago.ResumeLayout(false);
            tabPagepagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageAgregarPagos.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPago;
        private TabPage tabPagepagos;
        private TabPage tabPageAgregarPagos;
        private Panel panel1;
        private Button btnBuscar;
        private Button btnAñadirPago;
        private TextBox txtBuscarPago;
        private Button btnReembolso;
        private Button btnEditar;
        private DataGridView dataGridViewPagos;
        private Label lblTitulo;
        private TextBox txtFecha;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox txtTotal;
        private TextBox txtImpuesto;
        private Label label4;
        private Label label5;
        private TextBox txtMonto;
        private Label label3;
        private ComboBox cbTipoPagos;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox txtPasajero;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}