namespace Laboratorio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento que se dispara cuando se hace clic en el botón
        private void btnClickThis_Click(object sender, EventArgs e)
        {
            // Verifica que el control Label exista y cambia el texto
            lblHelloWorld.Text = "Hello World!";
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }
    }
}

