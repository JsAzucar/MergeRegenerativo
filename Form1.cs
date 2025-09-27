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
            lblResultado.Text = txtNombre.Text + "  dos";
            lblResultado.Text = txtNombre.Text + "  dos";
            lblResultado.Text = txtNombre.Text + "  dos";
            lblResultado.Text = txtNombre.Text + "  dos";
            lblResultado.Text = txtNombre.Text + "  dos";
            
        }





        private void Form1_Load(object sender, EventArgs e)
        {

            // Intentar conservar comentarios
 
            txtNombre.Text = "Mi nombre el Isamael remoto";
            txtNombre.Text = "Mi nombre el Isamael remoto";
            txtNombre.Text = "Mi nombre el Isamael remoto";
        }
    }
}
