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
            //AssociateAndRaiseViewEvents();

        }

        private void FormGestionPasajeros_Load(object sender, EventArgs e)
        {
            MostrarPasajeros();
            CargarPaises();
            CargarTiposDeDocumento();

        }


        private void MostrarPasajeros()
        {
            dataGridViewPasajero.DataSource = objetoCN.MostrarProd();
        }
        private void CargarPaises()
        {

            List<Modelo_Pais> listaPaises = negocioPais.ObtenerPaises();

            // Asigna la lista de países al ComboBox.
            cmbPais.DataSource = listaPaises;

            // Configura el nombre que se mostrará y el valor subyacente.
            cmbPais.DisplayMember = "Nombre"; // Esto es lo que el usuario verá en la lista desplegable.
            cmbPais.ValueMember = "Idpais"; // Esto es lo que se almacenará como valor.

            cmbPais.SelectedIndex = 0;
            //cmbPais.DataSource = negocioPais.ObtenerPaises(); // Asume que esto devuelve List<Modelo_Pais>
            // cmbPais.DisplayMember = "Nombre"; // Esto muestra el nombre del país en el ComboBox
            //cmbPais.ValueMember = "Idpais"; // Esto asocia el ID del país como valor interno en cada elemento
        }
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
      
            private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
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
                    // Asegúrate de convertir la fecha adecuadamente
                    //Fecha_Nacimiento = dtpFechaNacimiento.Value,
                    Fecha_Nacimiento = txtFechaNacimiento.Text,

                    // Esto asume que cmbPais.SelectedItem es un objeto que tiene una propiedad Id
                    Idpais = (int)cmbPais.SelectedValue,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text
                };

                negocioPasajeros.AgregarPasajero(nuevoPasajero);

                MessageBox.Show("Pasajero guardado con éxito.");
                LimpiarCampos();
                MostrarPasajeros();
                TcPasajero.SelectedTab = tabPagePasajeros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pasajero: " + ex.Message);
            }

        }
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
        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            TcPasajero.SelectedTab = tabAñadirPasajeros;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }
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




        #region BONTON EDITAR PASAJERO
        private void btnEditarPasajero_Click(object sender, EventArgs e)






















            /*

             try
             {
        // Verifica si el TextBox de búsqueda está vacío o solo contiene espacios en blanco.
        if (string.IsNullOrWhiteSpace(txtBuscarPasajero.Text))
        {
            // Si está vacío, muestra un mensaje y sale del método.
            MessageBox.Show("Ingrese un Nombre ");
            return;
        }

        // Realiza la búsqueda con el criterio proporcionado.
        var pasajeros = objetoCN.BuscarPasajerosPorNombre(txtBuscarPasajero.Text);

        // Verifica si la lista no es nula y luego actualiza el DataSource.
        if (pasajeros != null && pasajeros.Any())
        {
                  
                    dataGridViewPasajero.DataSource = pasajeros;
            txtBuscarPasajero.Clear(); // Limpia la caja de búsqueda solo si se encontraron resultados.
        }
       
                else
                {
          
                    // Si la lista está vacía o es nula, muestra un mensaje.
           
                    dataGridViewPasajero.DataSource = null; // Limpia el DataGridView si no hay resultados.
           
       
                }
             }
   
              catch (Exception ex)
   
             {
       
                // Maneja la excepción y muestra el mensaje de error.
       
                MessageBox.Show("Error al buscar pasajeros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
             }
           */
        }
        
    }
}

