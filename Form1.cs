namespace compraventa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_tipo.Items.Add("Moto");
            cbx_tipo.Items.Add("Carro");
            cbx_tipo.Items.Add("Bus");
            cbx_tipo.Items.Add("Camión");
            cbx_tipo.Items.Add("Bicicleta");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Obtener la información del formulario
            string tipo = cbx_tipo.SelectedItem?.ToString();
            string placa = txt_placa.Text;
            string modelo = txt_modelo.Text;
            string observaciones = richTextBox_observaciones.Text;


            // Crear una instancia de StreamWriter para escribir en el archivo de texto
            using (StreamWriter writer = new StreamWriter("informacion_vehiculo.txt", true))
            {
                // Escribir la información en el archivo de texto
                writer.WriteLine("Tipo: " + tipo);
                writer.WriteLine("Placa: " + placa);
                writer.WriteLine("Modelo: " + modelo);
                writer.WriteLine("Observaciones: " + observaciones);
                writer.WriteLine("-----------------------------------");
            }

            MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
