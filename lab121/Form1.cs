using System;
using System.Windows.Forms;

namespace lab121
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
                // Convertir las entradas de los TextBox en números
                double tiempo = double.Parse(Txt_tiempo.Text);
                double velocidad = double.Parse(Txt_velocidad.Text);

                // Calcular la distancia (Distancia = Velocidad * Tiempo)
                double distancia = velocidad * tiempo;

                // Mostrar la distancia en el TextBox correspondiente
                Txt_distancia.Text = distancia.ToString("F2"); // F2 para mostrar solo 2 decimales
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón "Limpiar"
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_tiempo.Clear();
            Txt_velocidad.Clear();
            Txt_distancia.Clear();
        }

        // Evento para el botón "Salir"
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
