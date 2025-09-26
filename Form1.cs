namespace PruebaMerge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Vamos a probar el merge con Visual Studio
            lblResultado.Text = txtNombre.text + " Prueba merge ";
            lblResultado.Text = txtNombre.Text + "  Felicidades sin unión";
            lblResultado.Text = txtNombre.Text + "  Felicidades lhsIntentarCambiar";
            //Necesito que los cambios funciones para reflejar el ejemplo
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
