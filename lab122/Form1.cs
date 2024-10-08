using System;
using System.Windows.Forms;

namespace lab122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para el botón "Calcular"
        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener las notas de los TextBox
                double nota1 = double.Parse(Txt_nota1.Text);
                double nota2 = double.Parse(Txt_nota2.Text);
                double nota3 = double.Parse(Txt_nota3.Text);

                // Calcular el promedio
                double promedio = (nota1 + nota2 + nota3) / 3;

                // Mostrar el promedio en el TextBox correspondiente
                Txt_promedio.Text = promedio.ToString("F2"); // F2 para mostrar solo 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón "Limpiar"
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_nota1.Clear();
            Txt_nota2.Clear();
            Txt_nota3.Clear();
            Txt_promedio.Clear();
        }

        // Evento para el botón "Salir"
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

