
using capadenegocio;



namespace Capadepresentacion
{
    public partial class Form1 : Form
    {
        CN_Pasajeros objetoCN = new CN_Pasajeros();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPasajeros();

        }

        private void MostrarPasajeros()
        {
            dataGridView1.DataSource = objetoCN.MostrarProd();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}