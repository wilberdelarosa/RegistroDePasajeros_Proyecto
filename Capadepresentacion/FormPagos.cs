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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static Capadedatos.Modelo_Pasajeros;
using Controllers;


namespace Capadepresentacion
{
    public partial class FormPagos : Form
    {
        MainController oMainController = new MainController();



        CN_Pasajeros negocioPasajero = new CN_Pasajeros();
        CD_Pago datosPago = new CD_Pago();
        CN_Pago negocioPago = new CN_Pago();


        public FormPagos()
        {
            InitializeComponent();
            this.dataGridViewPagos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPagos_CellFormatting);
            MostrarPago();
            txtBuscarPago.KeyUp += new KeyEventHandler(txtBuscarPago_KeyUp);
            cbTipoPagos.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPasajero.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            MostrarPago();
            CargarTiposDeDocumento();
            LlenarComboBoxPasajeros();
            AdjustDatagridviewHeight();
        }
        private void AdjustDatagridviewHeight()
        {
            var height = dataGridViewPagos.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dataGridViewPagos.Rows)
            {
                height += dr.Height;
            }

            dataGridViewPagos.Height = height;
        }
        #region LLENADO DE DATAGRID
        private void MostrarPago()

        {
            dataGridViewPagos.DataSource = oMainController.GetMantenimientos();

            //  var listaPago = negocioPago.MostrarDatosPagos();

            // Asegurándonos de que el DataSource se actualiza correctamente
            //dataGridViewPagos.DataSource = null; // Limpiar el DataSource actual
            //  dataGridViewPagos.DataSource = listaPago;
        }
        #endregion

        #region LLENADO DE COMBO BOX TIPO DE DOC

        private void CargarTiposDeDocumento()
        {
            cbTipoPagos.DataSource = tiposDePagos;
            cbTipoPagos.SelectedIndex = -1; // deja en bllanco la seleccion
        }
        private List<string> tiposDePagos = new List<string>
        {
          "Tarjeta", 
          "Credito",
         "Transferencia",

        };

        #endregion

        #region LLENADO DE COMBO BOX PASAJEROS

        public void LlenarComboBoxPasajeros()
        {


            try
            {
                // Obtén la lista de pasajeros desde la capa de negocio
                List<Modelo_Pasajeros> listaPasajeros = negocioPasajero.ObtenerPasajerosConIdYNombre0();

                // Limpia el ComboBox antes de llenarlo
                txtPasajero.DataSource = null;  // Asegúrate de que el nombre del ComboBox es correcto
                txtPasajero.DisplayMember = "Text";
                txtPasajero.ValueMember = "Value";
                txtPasajero.Items.Clear();

                // Recorre la lista y añade los elementos al ComboBox
                foreach (var pasajero in listaPasajeros)
                {
                    // Formato: "ID - Nombre"
                    txtPasajero.Items.Add(new { Text = $"{pasajero.Id} - {pasajero.Nombre}", Value = pasajero.Id });

                }

                // Si necesitas configurar el modo de autocompletado
               // txtPasajero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //txtPasajero.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox: " + ex.Message);
            }



        }

        #endregion

        #region BOTON GUARDAR
        private Modelo_Pago pagoActual;
        private bool ModoEdicion = false;


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //me quede aqui

            if (!ValidarDatosFormularioPago())
                return;



            if (txtPasajero.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un pasajero.");
                return;
            }

            try
            {
                // Parsea el texto a DateOnly


                // Obtener el ID del pasajero desde el ComboBox
                int idPasajero = (int)(txtPasajero.SelectedItem as dynamic).Value;
                int monto = int.Parse(txtMonto.Text);
                // string tipoPago = cbTipoPagos.SelectedItem.ToString();
                DateOnly fecha = DateOnly.Parse(txtFecha.Text);

                if (ModoEdicion && pagoActual != null)
                {
                    // Actualiza el pago existente
                    pagoActual.Fecha = fecha;
                    pagoActual.Idpasajero = idPasajero;
                    pagoActual.Monto = monto;
                    pagoActual.Tipo_pago = cbTipoPagos.SelectedItem.ToString();

                    negocioPago.ActualizarPago(pagoActual);
                    LimpiarCampos();

                    MessageBox.Show("Pago actualizado con éxito.");
                }
                else
                {
                    // Crea un nuevo pago
                    Modelo_Pago nuevoPago = new Modelo_Pago
                    {
                        Fecha = fecha,
                        Idpasajero = idPasajero,
                        Monto = monto,
                        Tipo_pago = cbTipoPagos.SelectedItem.ToString(),
                    };

                    negocioPago.AgregarPago(nuevoPago);
                    MessageBox.Show("Nuevo pago guardado con éxito.");
                }

                LimpiarCampos();
                MostrarPago();
                tabControlPago.SelectedTab = tabPagepagos; // Cambia a la pestaña de lista de pagos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el pago: " + ex.Message);
            }

        }
        #endregion

        #region METODO lIMPIAR CAMPOS

        private void LimpiarCampos()
        {
            // Limpia los campos de texto relacionados a pagos
            txtFecha.Clear();
            txtPasajero.SelectedIndex = -1;
            cbTipoPagos.SelectedIndex = -1;
            txtMonto.Clear();
            txtImpuesto.Clear();
            txtTotal.Clear();
        }
        #endregion



        #region METODO PARA IDENTIFICAR SELECCION
        public void SeleccionarPasajeroEnComboBox(int idPasajero)
        {
            foreach (var item in txtPasajero.Items)
            {
                if (item is { } anonymousItem && (int)anonymousItem.GetType().GetProperty("Value").GetValue(anonymousItem) == idPasajero)
                {
                    txtPasajero.SelectedItem = item;
                    break;
                }
            }
        }
        #endregion

        #region METODO LLENAR CAMPOS PARA ACTUALIZAR

        private void LlenarDatosParaEditarPago(Modelo_Pago pago)
        {
            txtFecha.Text = pago.Fecha.ToString("yyyy-MM-dd");
            SeleccionarPasajeroEnComboBox(pago.Idpasajero); // Asegúrate de que esta línea se ejecute después de LlenarComboBoxPasajeros()
            txtMonto.Text = pago.Monto.ToString(); // Asegúrate de que el control puede mostrar el monto correctamente
            cbTipoPagos.SelectedItem = pago.Tipo_pago;
            txtImpuesto.Text = pago.Impuesto.ToString(); // Muestra el cálculo de impuesto
            txtTotal.Text = pago.Total.ToString(); // Muestra el cálculo del total
        }
        #endregion

        #region METODO VALIDAR CAMPOS
        private bool ValidarDatosFormularioPago()
        {

            if (string.IsNullOrWhiteSpace(txtFecha.Text) ||
                string.IsNullOrWhiteSpace(txtPasajero.Text) ||
                string.IsNullOrWhiteSpace(txtMonto.Text) ||
                cbTipoPagos.SelectedIndex == -1)

            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            // Aquí irían más validaciones como la correcta conversión de tipos, rangos, etc.
            return true;
        }
        #endregion

        #region BOTON AÑADIR
        private void btnAñadirPago_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            ModoEdicion = false;
            tabControlPago.SelectedTab = tabPageAgregarPagos; ;
            //lblTitulo.Text = "Agregar Pago";
            btnGuardar.Text = "Guardar";

        }
        #endregion

        #region BOTON CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        #endregion

        #region BOTON BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarPago.Text))
            {
                MostrarPago();

                MessageBox.Show("Ingresa un Nombre");
            }
            else
            {
                string criterio = txtBuscarPago.Text.Trim();
                var resultado = negocioPago.BuscarPagosPorIdONombre(criterio);
                dataGridViewPagos.DataSource = resultado; // Asume que tienes un DataGridView llamado dataGridViewPagos
                txtBuscarPago.Clear();
            }
        }

        #endregion

        #region BOTON EDITAR 
        private void btnEditar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            try
            {
                if (dataGridViewPagos.SelectedRows.Count > 0)
                {
                    int idPasajero = Convert.ToInt32(dataGridViewPagos.SelectedRows[0].Cells["idpasajero"].Value); // Asumiendo que tienes una columna "Id"
                    Modelo_Pago pagoAEditar = negocioPago.ObtenerPagoPorId(idPasajero);
                    // Suponiendo que txtPasajero es tu ComboBox

                    if (pagoAEditar != null)
                    {
                        txtPasajero.SelectedValue = pagoAEditar.Idpasajero;

                        LlenarDatosParaEditarPago(pagoAEditar);

                        ModoEdicion = true; // Establece el formulario en modo de edición
                        pagoActual = pagoAEditar; // Guarda el pasajero actual para actualizar
                        tabControlPago.SelectedTab = tabPageAgregarPagos; // Cambia a la pestaña de edición
                        //lblTitulo.Text = "Editar Pasajero";
                        btnGuardar.Text = "Actualizar";

                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un pasajero para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el pasajero: " + ex.Message);
            }
        }
        #endregion

        #region COMBO BOX PASAJERO
        private void txtPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region AJUSTE DE COLORES DE ESTADOS DE PAGOS
        private void dataGridViewPagos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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
        }
        #endregion

        #region BOTON REEMBOLSO

        private void btnReembolso_Click(object sender, EventArgs e)
        {
            if (dataGridViewPagos.SelectedRows.Count > 0)
            {
                // Obtiene los datos del pago seleccionado
                int idPago = Convert.ToInt32(dataGridViewPagos.SelectedRows[0].Cells["idpago"].Value);
                string nombrePasajero = dataGridViewPagos.SelectedRows[0].Cells["nombre_pasajero"].Value.ToString();
                decimal monto = Convert.ToDecimal(dataGridViewPagos.SelectedRows[0].Cells["monto"].Value);

                // Pregunta al usuario si está seguro de realizar el reembolso
                var confirmResult = MessageBox.Show($"¿Está seguro que desea realizar un reembolso de {monto:C} a {nombrePasajero}?",
                                                    "Confirmar reembolso",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Realiza el reembolso
                        negocioPago.RealizarReembolso0(idPago);
                        MessageBox.Show("El reembolso se realizó correctamente .");
                        MostrarPago(); // Actualiza la lista para reflejar el cambio
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al realizar el reembolso: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un pago para realizar el reembolso .");
            }

        }
        #endregion

        private void FormPagos_KeyUp(object sender, KeyEventArgs e)
        {


        }
# region busqueda automatica

        private void txtBuscarPago_KeyUp(object sender, KeyEventArgs e)
        {
            string SearchValue = txtBuscarPago.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(SearchValue))
            {
                var listaFiltrada = datosPago.BuscarPagosPorIdONombre(SearchValue);
                dataGridViewPagos.DataSource = listaFiltrada;
            }
            else
            {
                MostrarPago(); // Esto restablece la vista si no hay texto de búsqueda
            }
           
        }
        #endregion
    }
}
