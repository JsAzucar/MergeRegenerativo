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
            lblResultado.Text = txtNombre.Text + "  Felicidades lhs";
            //Necesito que los cambios funciones para reflejar el ejemplo
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
