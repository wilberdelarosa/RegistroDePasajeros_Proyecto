using Capadedatos;
using capadenegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capadepresentacion
{
    public partial class FormConsultas : Form
    {
        CN_Pasajeros negocioPasajero = new CN_Pasajeros();
        CD_Pais negocioPais = new CD_Pais();
        CN_Pago negocioPago = new CN_Pago();
        public FormConsultas()
        {
            InitializeComponent();
            this.dataGridViewPagos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPagos_CellFormatting);
            this.btnLimpiar.Click += new EventHandler(btnLimpiar_Click_1);

            txtIdPasajero.TextChanged += new EventHandler(BusquedaCambio);
            txtNombre.TextChanged += new EventHandler(BusquedaCambio);
            cbTipoPago.SelectedIndexChanged += new EventHandler(BusquedaCambio);
            cbEstado.SelectedIndexChanged += new EventHandler(BusquedaCambio);
            cbPais.SelectedIndexChanged += new EventHandler(BusquedaCambio);
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {
            LlenarComboBoxes();
            MostrarPagosIniciales();
            CargarPaises();
            LimpiarCampos();

        }
        private void BusquedaCambio(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e); // Llama directamente al evento click del botón de búsqueda
        }
        private void LimpiarCampos()
        {
            // Asumiendo que tienes TextBoxes, ComboBoxes y quizás otros controles para limpiar
            txtIdPasajero.Clear();
            txtNombre.Clear();
            cbPais.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            cbTipoPago.SelectedIndex = -1;


        }
        private void LlenarComboBoxes()
        {
            // Cargar tipos de pago
            var tiposDePago = new List<string> { "Tarjeta", "Credito", "Transferencia" }; // Ejemplo estático
            cbTipoPago.DataSource = tiposDePago;

            // Cargar estados
            var estados = new List<string> { "Acreditado", "Reembolsado" }; // Ejemplo estático
            cbEstado.DataSource = estados;


        }
        private void CargarPaises()
        {

            List<Modelo_Pais> listaPaises = negocioPais.ObtenerPaises();

            // Asigna la lista de países al ComboBox.
            cbPais.DataSource = listaPaises;

            // Configura el nombre que se mostrará y el valor subyacente.
            cbPais.DisplayMember = "Nombre"; // Esto es lo que el usuario verá en la lista desplegable.
            cbPais.ValueMember = "Nombre"; // Esto es lo que se almacenará como valor.

            cbPais.SelectedIndex = 0;

        }

        private void MostrarPagosIniciales()
        {
            CN_Pago cnPago = new CN_Pago();
            List<ModeloConsultaAvanzada> resultados = cnPago.BuscarPagosAvanzados(null, null, null, null, null);

            // Obtener todos los pagos sin aplicar filtros
            //var resultados = cnPago.BuscarPagosAvanzados(null, null, null, null, null);

            // Asignar los resultados al DataGrid de pagos
            dataGridViewPagos.DataSource = resultados.Select(p => new
            {
                p.Idpago,
                p.Fecha,
                p.Tipo_pago,
                p.Monto,
                p.Impuesto,
                p.Total,
                p.Estado

            }).ToList();

            // Asignar los resultados al DataGrid de pasajeros
            dataGridViewPasajeros.DataSource = resultados.Select(p => new
            {
                p.Idpasajero,
                p.Nombre_pasajero,
                p.Apellido,
                p.Tipo_documento,
                p.Num_documento,
                p.Fecha_nacimiento,
                p.Telefono,
                p.Email,
                p.Pais // Asegúrate de que este campo esté incluido en tu modelo y sea el nombre correcto.
            }).ToList();

          
            dataGridViewPagos.Columns["Fecha"].HeaderText = "Fecha de Pago";
            dataGridViewPagos.Columns["Monto"].DefaultCellStyle.Format = "C2"; // Formato de moneda

            // Ajustar el ancho de las columnas según sea necesario
            dataGridViewPagos.AutoResizeColumns();
            dataGridViewPasajeros.AutoResizeColumns();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Verifica si todos los campos están vacíos
            if (string.IsNullOrWhiteSpace(txtIdPasajero.Text) &&
                string.IsNullOrWhiteSpace(txtNombre.Text) &&
                cbTipoPago.SelectedIndex == -1 &&
                cbEstado.SelectedIndex == -1 &&
                cbPais.SelectedIndex == -1)
            {
                MostrarPagosIniciales();

                // Muestra un mensaje indicando que se debe ingresar al menos un criterio
                // MessageBox.Show("Por favor, ingrese al menos un criterio para filtrar la búsqueda.", "Criterio de Búsqueda Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MostrarPagosIniciales();

                int? idPasajero = !string.IsNullOrWhiteSpace(txtIdPasajero.Text) && int.TryParse(txtIdPasajero.Text, out int id) ? id : (int?)null;
                string nombre = txtNombre.Text.Trim();
                string tipoPago = cbTipoPago.SelectedItem?.ToString(); // Usa '?' para manejar nulos
                string estado = cbEstado.SelectedItem?.ToString(); // Usa '?' para manejar nulos
                string pais = cbPais.SelectedValue?.ToString(); // Usa '?' para manejar nulos

                CN_Pago cnPago = new CN_Pago();
                List<ModeloConsultaAvanzada> resultados = cnPago.BuscarPagosAvanzados(idPasajero, nombre, tipoPago, estado, pais);

                // Asignar los resultados a los DataGrids. Asumiendo que tienes dos DataGrids:
                // Uno para pagos y otro para detalles del pasajero
                dataGridViewPagos.DataSource = resultados.Select(p => new
                {
                    p.Idpago,
                    p.Fecha,
                    p.Monto,
                    p.Tipo_pago,
                    p.Impuesto,
                    p.Total,
                    p.Estado
                }).ToList();

                dataGridViewPasajeros.DataSource = resultados.Select(p => new
                {
                    p.Idpasajero,
                    p.Nombre_pasajero,
                    p.Apellido,
                    p.Pais,
                    p.Tipo_documento,
                    p.Num_documento,
                    p.Fecha_nacimiento,
                    p.Telefono,
                    p.Email
                }).ToList();

                RealizarBusqueda();

            }


        }

        private void RealizarBusqueda()
        {
            int? idPasajero = int.TryParse(txtIdPasajero.Text, out int id) ? id : (int?)null;
            string nombre = txtNombre.Text.Trim();
            string tipoPago = cbTipoPago.SelectedIndex >= 0 ? cbTipoPago.SelectedItem.ToString() : null;
            string estado = cbEstado.SelectedIndex >= 0 ? cbEstado.SelectedItem.ToString() : null;
            string pais = cbPais.SelectedIndex >= 0 ? cbPais.SelectedValue.ToString() : null;

            var resultados = negocioPago.BuscarPagosAvanzados(idPasajero, nombre, tipoPago, estado, pais);

            // Actualiza los DataGrids con los resultados obtenidos.
            dataGridViewPagos.DataSource = resultados.Select(p => new
            {
                p.Idpago,
                p.Fecha,
                p.Monto,
                p.Tipo_pago,
                p.Impuesto,
                p.Total,
                p.Estado
            }).ToList();

            dataGridViewPasajeros.DataSource = resultados.Select(p => new
            {
                p.Idpasajero,
                p.Nombre_pasajero,
                p.Apellido,
                p.Pais,
                p.Tipo_documento,
                p.Num_documento,
                p.Fecha_nacimiento,
                p.Telefono,
                p.Email
            }).ToList();
        }


        private void dataGridViewPagos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Configuración para dataGridViewPagos
            // Asumiendo que el nombre de la columna de estado es "Estado"
            if (dataGridViewPagos.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
            {
                // Aplica formato solo a la columna "Estado"
                switch (e.Value.ToString())
                {
                    case "Reembolsado":
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;  // Cambia el color del texto si es necesario
                        break;
                    case "Acreditado":
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    default:
                        e.CellStyle.BackColor = dataGridViewPagos.DefaultCellStyle.BackColor;
                        e.CellStyle.ForeColor = dataGridViewPagos.DefaultCellStyle.ForeColor;
                        break;
                }
            }

            // No olvides llamar a este método en el constructor después de InitializeComponents o donde lo consideres necesario.
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            MostrarPagosIniciales();
            MessageBox.Show("Los campos de búsqueda han sido limpiados y los resultados han sido restablecidos.", "Campos Limpiados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
