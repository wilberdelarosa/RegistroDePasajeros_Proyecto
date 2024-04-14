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
            txtPasajero = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cbTipoPagos = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtTotal = new TextBox();
            txtImpuesto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtMonto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblTitulo = new Label();
            txtFecha = new TextBox();
            tabControlPago.SuspendLayout();
            tabPagepagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).BeginInit();
            panel1.SuspendLayout();
            tabPageAgregarPagos.SuspendLayout();
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
            tabControlPago.Size = new Size(1461, 745);
            tabControlPago.TabIndex = 0;
            // 
            // tabPagepagos
            // 
            tabPagepagos.Controls.Add(dataGridViewPagos);
            tabPagepagos.Controls.Add(panel1);
            tabPagepagos.Location = new Point(4, 26);
            tabPagepagos.Name = "tabPagepagos";
            tabPagepagos.Padding = new Padding(3);
            tabPagepagos.Size = new Size(1453, 715);
            tabPagepagos.TabIndex = 0;
            tabPagepagos.Text = "Pagos";
            tabPagepagos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPagos
            // 
            dataGridViewPagos.BackgroundColor = SystemColors.Window;
            dataGridViewPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPagos.Dock = DockStyle.Fill;
            dataGridViewPagos.Location = new Point(3, 136);
            dataGridViewPagos.Name = "dataGridViewPagos";
            dataGridViewPagos.RowHeadersWidth = 51;
            dataGridViewPagos.RowTemplate.Height = 29;
            dataGridViewPagos.Size = new Size(1447, 576);
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
            tabPageAgregarPagos.Controls.Add(txtPasajero);
            tabPageAgregarPagos.Controls.Add(btnCancelar);
            tabPageAgregarPagos.Controls.Add(btnGuardar);
            tabPageAgregarPagos.Controls.Add(cbTipoPagos);
            tabPageAgregarPagos.Controls.Add(label6);
            tabPageAgregarPagos.Controls.Add(label7);
            tabPageAgregarPagos.Controls.Add(txtTotal);
            tabPageAgregarPagos.Controls.Add(txtImpuesto);
            tabPageAgregarPagos.Controls.Add(label4);
            tabPageAgregarPagos.Controls.Add(label5);
            tabPageAgregarPagos.Controls.Add(txtMonto);
            tabPageAgregarPagos.Controls.Add(label3);
            tabPageAgregarPagos.Controls.Add(label2);
            tabPageAgregarPagos.Controls.Add(lblTitulo);
            tabPageAgregarPagos.Controls.Add(txtFecha);
            tabPageAgregarPagos.ForeColor = Color.Black;
            tabPageAgregarPagos.Location = new Point(4, 29);
            tabPageAgregarPagos.Name = "tabPageAgregarPagos";
            tabPageAgregarPagos.Padding = new Padding(3);
            tabPageAgregarPagos.Size = new Size(1453, 712);
            tabPageAgregarPagos.TabIndex = 1;
            tabPageAgregarPagos.Text = "Agregar Pagos";
            tabPageAgregarPagos.UseVisualStyleBackColor = true;
            // 
            // txtPasajero
            // 
            txtPasajero.FormattingEnabled = true;
            txtPasajero.Location = new Point(493, 213);
            txtPasajero.Name = "txtPasajero";
            txtPasajero.Size = new Size(197, 25);
            txtPasajero.TabIndex = 16;
            txtPasajero.SelectedIndexChanged += txtPasajero_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(621, 646);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(435, 646);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbTipoPagos
            // 
            cbTipoPagos.FormattingEnabled = true;
            cbTipoPagos.Location = new Point(493, 417);
            cbTipoPagos.Name = "cbTipoPagos";
            cbTipoPagos.Size = new Size(197, 25);
            cbTipoPagos.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(565, 559);
            label6.Name = "label6";
            label6.Size = new Size(41, 17);
            label6.TabIndex = 12;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(553, 461);
            label7.Name = "label7";
            label7.Size = new Size(70, 17);
            label7.TabIndex = 11;
            label7.Text = "Impuesto";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(493, 579);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(197, 25);
            txtTotal.TabIndex = 10;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(493, 481);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(197, 25);
            txtImpuesto.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(536, 385);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 8;
            label4.Text = "Tipo de patos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(559, 287);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 7;
            label5.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(493, 307);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(197, 25);
            txtMonto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 193);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 4;
            label3.Text = "Pasajero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(559, 95);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 3;
            label2.Text = "Fecha";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(510, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(138, 17);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "AGREGAR PAGOS";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(493, 115);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(197, 25);
            txtFecha.TabIndex = 0;
            // 
            // FormPagos
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 745);
            Controls.Add(tabControlPago);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.MidnightBlue;
            Name = "FormPagos";
            Text = "FormPagos";
            Load += FormPagos_Load;
            tabControlPago.ResumeLayout(false);
            tabPagepagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageAgregarPagos.ResumeLayout(false);
            tabPageAgregarPagos.PerformLayout();
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
    }
}