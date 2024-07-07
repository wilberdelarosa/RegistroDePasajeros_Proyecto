using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Capadedatos;
using capadenegocio;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Capadepresentacion
{
    public partial class FormGestionPasajeros : Form
    {
        CN_Pasajeros objetoCN = new CN_Pasajeros();
        CD_Pais negocioPais = new CD_Pais();

        private CN_Pasajeros negocioPasajeros = new CN_Pasajeros();

        public FormGestionPasajeros()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormGestionPasajeros_Load);
            this.btnAgregarPasajero.Click += new EventHandler(this.btnAgregarPasajero_Click);
            dataGridViewPasajero.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.btnEditarPasajero.Click += new EventHandler(this.btnEditarPasajero_Click);
            this.btnEliminarPasajero.Click += new EventHandler(this.btnEliminarPasajero_Click);
            txtBuscarPasajero.TextChanged += new EventHandler(txtBuscarPasajero_TextChanged);
            dataGridViewPasajero.ReadOnly = true;

            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            MostrarPasajeros();

        }

        private void txtBuscarPasajero_TextChanged(object sender, EventArgs e)
        {
            FiltrarPasajeros(txtBuscarPasajero.Text);
        }

        private void FiltrarPasajeros(string criterio)
        {
            // Verifica si el criterio es nulo o está vacío
            if (string.IsNullOrWhiteSpace(criterio))
            {
                MostrarPasajeros();
            }
            else
            {
                try
                {
                    // Filtra los datos utilizando el criterio y actualiza el DataGridView
                    var resultadosFiltrados = objetoCN.BuscarPasajerosPorNombre(criterio);
                    dataGridViewPasajero.DataSource = resultadosFiltrados;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al filtrar los pasajeros: " + ex.Message);
                }
            }
        }

        private void FormGestionPasajeros_Load(object sender, EventArgs e)
        {
            MostrarPasajeros();
            CargarPaises();
            CargarTiposDeDocumento();
            LimpiarCampos();

        }

        #region REFRESCAR DATAGRID

        private void MostrarPasajeros()
        {
            //dataGridViewPasajero.DataSource = objetoCN.MostrarProd();
            var listaPasajeros = objetoCN.MostrarDatosPasajeros();

            // Asegurándonos de que el DataSource se actualiza correctamente
            dataGridViewPasajero.DataSource = null; // Limpiar el DataSource actual
            dataGridViewPasajero.DataSource = listaPasajeros;
        }
        #endregion

        #region METODO LLENADO COMBOBOX
        private void CargarPaises()
        {

            List<Modelo_Pais> listaPaises = negocioPais.ObtenerPaises();

            // Asigna la lista de países al ComboBox.
            cmbPais.DataSource = listaPaises;

            // Configura el nombre que se mostrará y el valor subyacente.
            cmbPais.DisplayMember = "Nombre"; // Esto es lo que el usuario verá en la lista desplegable.
            cmbPais.ValueMember = "Idpais"; // Esto es lo que se almacenará como valor.

            cmbPais.SelectedIndex = 0;

        }
        #endregion

        #region METODO LLENADO COMBOBOX DOCUMENTO
        private void CargarTiposDeDocumento()
        {
            cmbTipoDocumento.DataSource = tiposDeDocumento;
            cmbTipoDocumento.SelectedIndex = 0; // Opcional: selecciona el primer tipo por defecto
        }
        private List<string> tiposDeDocumento = new List<string>
{
    "DNI", // Documento Nacional de Identidad
    "Pasaporte",
    "Licencia de Conducir",

};
        #endregion

        #region BOTON GUARDAR

        private void ValidarCampos()
        {
            // Asumiendo que tienes campos como nombre, apellido, etc.
            if (string.IsNullOrWhiteSpace(txtNombrePasajero.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPasajero.Text) ||
                string.IsNullOrWhiteSpace(txtFechaNacimiento.Text) ||
                 string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) ||
                 string.IsNullOrWhiteSpace(cmbTipoDocumento.SelectedItem.ToString()) ||

                  string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("No deje campos vacíos para pasajero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Continuar con el procesamiento o guardado de datos
            }
        }
        private Modelo_Pasajeros pasajeroActual;
        private bool esModoEdicion = false;


        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {

                ValidarCampos();

                // Si estás en modo de edición, actualiza el pasajero.
                // De lo contrario, crea un nuevo pasajero.
                if (esModoEdicion && pasajeroActual != null)
                {
                    // Actualizar el pasajero existente
                    pasajeroActual.Nombre = txtNombrePasajero.Text;
                    pasajeroActual.Apellido = txtApellidoPasajero.Text;
                    pasajeroActual.Tipo_documento = cmbTipoDocumento.SelectedItem.ToString();
                    pasajeroActual.Num_documento = txtNumeroDocumento.Text;
                    pasajeroActual.Fecha_Nacimiento = txtFechaNacimiento.Text;
                    pasajeroActual.Idpais = (int)cmbPais.SelectedValue;
                    pasajeroActual.Telefono = txtTelefono.Text;
                    pasajeroActual.Email = txtEmail.Text;



                    objetoCN.ActualizarPasajero(pasajeroActual);
                    LimpiarCampos();

                    esModoEdicion = false;
                    TcPasajero.SelectedTab = tabPagePasajeros;
                    MessageBox.Show("Pasajero actualizado con éxito.");
                    MostrarPasajeros();
                }
                else
                {



                    if (cmbPais.SelectedIndex < 0)
                    {
                        MessageBox.Show("Por favor, seleccione un país.");
                        return;
                    }

                    Modelo_Pasajeros nuevoPasajero = new Modelo_Pasajeros
                    {
                        Nombre = txtNombrePasajero.Text,
                        Apellido = txtApellidoPasajero.Text,
                        Tipo_documento = cmbTipoDocumento.SelectedItem.ToString(),
                        Num_documento = txtNumeroDocumento.Text,

                        Fecha_Nacimiento = txtFechaNacimiento.Text,


                        Idpais = (int)cmbPais.SelectedValue,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text
                    };

                    negocioPasajeros.AgregarPasajero(nuevoPasajero);

                    MessageBox.Show("Pasajero guardado con éxito.");
                    LimpiarCampos();

                    TcPasajero.SelectedTab = tabPagePasajeros;
                    MostrarPasajeros();

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pasajero: " + ex.Message);
            }

        }
        #endregion

        #region METODO LIMPIAR
        private void LimpiarCampos()
        {
            // Limpia los campos de texto y restablece los ComboBoxes
            txtNombrePasajero.Clear();
            txtApellidoPasajero.Clear();
            cmbTipoDocumento.SelectedIndex = -1; // o 0 para seleccionar el primer elemento
            txtNumeroDocumento.Clear();
            txtFechaNacimiento.Clear(); // o dtpFechaNacimiento.Value = DateTime.Now; si es un DateTimePicker
            cmbPais.SelectedIndex = -1; // o 0 para seleccionar el primer elemento
            txtTelefono.Clear();
            txtEmail.Clear();
        }
        #endregion

        #region METODO LLENAR
        private void LlenarDatosParaEditar(Modelo_Pasajeros pasajero)
        {


            txtNombrePasajero.Text = pasajero.Nombre;
            txtApellidoPasajero.Text = pasajero.Apellido;
            cmbTipoDocumento.SelectedItem = pasajero.Tipo_documento; // Asegúrate de que el valor exista en los ítems
            txtNumeroDocumento.Text = pasajero.Num_documento;
            txtFechaNacimiento.Text = pasajero.Fecha_Nacimiento; // Ajusta según el control que uses
            cmbPais.SelectedValue = pasajero.Idpais;
            txtTelefono.Text = pasajero.Telefono;
            txtEmail.Text = pasajero.Email;






        }

        #endregion

        #region BOTON AGREGAR USUARIO
        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            esModoEdicion = false;
            TcPasajero.SelectedTab = tabAñadirPasajeros;
            lblTituloFormulario.Text = "Agregar Pasajero";
            btnGuardar.Text = "Guardar";
            LimpiarCampos();

        }
        #endregion

        #region BOTON CANCELAR

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
        #endregion

        #region BOTON BUSCAR PASAJERO 
        private void btnBuscarPasajero_Click(object sender, EventArgs e)
        {


            // Verificar si el TextBox de búsqueda está vacío
            if (string.IsNullOrWhiteSpace(txtBuscarPasajero.Text))
            {
                MostrarPasajeros();

                MessageBox.Show("Ingresa un Nombre");
            }
            else
            {
                try
                {
                    DataTable pasajeros = objetoCN.BuscarPasajerosPorNombre(txtBuscarPasajero.Text);
                    dataGridViewPasajero.DataSource = pasajeros;

                    // Si se encontraron resultados, limpiar el TextBox
                    if (pasajeros.Rows.Count > 0)
                    {
                        txtBuscarPasajero.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron pasajeros con ese nombre.", "Buscar Pasajeros");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar pasajeros: " + ex.Message, "Error");
                }
            }



        }
        #endregion

        #region BONTON EDITAR PASAJERO
        private void btnEditarPasajero_Click(object sender, EventArgs e)

        {
            LimpiarCampos();

            try
            {
                if (dataGridViewPasajero.SelectedRows.Count > 0)
                {
                    int idPasajero = Convert.ToInt32(dataGridViewPasajero.SelectedRows[0].Cells["idpasajero"].Value); // Asumiendo que tienes una columna "Id"
                    Modelo_Pasajeros pasajeroAEditar = negocioPasajeros.ObtenerPasajeroPorId(idPasajero);

                    if (pasajeroAEditar != null)
                    {
                        LlenarDatosParaEditar(pasajeroAEditar);

                        esModoEdicion = true; // Establece el formulario en modo de edición
                        pasajeroActual = pasajeroAEditar; // Guarda el pasajero actual para actualizar
                        TcPasajero.SelectedTab = tabAñadirPasajeros; // Cambia a la pestaña de edición
                        lblTituloFormulario.Text = "Editar Pasajero";
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

        private int ObtenerIdPasajeroSeleccionado()
        {
            // Asegúrate de que haya una fila seleccionada
            if (dataGridViewPasajero.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un pasajero de la lista.");
                return -1; // Retorna -1 como indicador de que no hay selección
            }

            // Obtiene la primera fila seleccionada
            DataGridViewRow filaSeleccionada = dataGridViewPasajero.SelectedRows[0];

            // Asegúrate de que la celda que contiene el ID no es null y contiene un valor entero
            if (filaSeleccionada.Cells["idpasajero"].Value == null || !int.TryParse(filaSeleccionada.Cells["idpasajero"].Value.ToString(), out int idPasajero))
            {
                MessageBox.Show("Ha ocurrido un error al obtener el ID del pasajero.");
                return -1; // Retorna -1 como indicador de error
            }

            return idPasajero; // Retorna el ID del pasajero seleccionado
        }


        #endregion

        #region BOTON ELIMINAR PASAJEROS

        private void btnEliminarPasajero_Click(object sender, EventArgs e)

        {

            if (dataGridViewPasajero.SelectedRows.Count > 0)
            {
                // Obtiene el ID del pasajero seleccionado
                int idPasajero = Convert.ToInt32(dataGridViewPasajero.SelectedRows[0].Cells["idpasajero"].Value);
                // Confirma la eliminación con el usuario
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este pasajero?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        // Llama al método en la capa de negocio para eliminar el pasajero
                        objetoCN.EliminarPasajero(idPasajero); // Asume que objetoCN es tu objeto de capa de negocio

                        // Muestra un mensaje de éxito
                        MessageBox.Show("Pasajero eliminado correctamente.");

                        // Actualiza la lista de pasajeros para reflejar la eliminación
                        MostrarPasajeros();
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        MessageBox.Show("Ocurrió un error al eliminar el pasajero: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pasajero para eliminar.");
            }





        }
        #endregion

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


















 



