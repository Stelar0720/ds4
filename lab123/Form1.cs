using System;
using System.Windows.Forms;

namespace lab123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método para calcular el semiperímetro
        private double CalcularSemiperimetro(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA + ladoB + ladoC) / 2;
        }

        // Método para calcular el área usando la fórmula de Herón
        private double CalcularArea(double ladoA, double ladoB, double ladoC, double semiperimetro)
        {
            return Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
        }

        // Evento para el botón "Calcular Área"
        private void Btn_area_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los lados del triángulo
                double ladoA = double.Parse(Txt_ladoa.Text);
                double ladoB = double.Parse(Txt_ladob.Text);
                double ladoC = double.Parse(Txt_ladoc.Text);

                // Calcular semiperímetro y área
                double semiperimetro = CalcularSemiperimetro(ladoA, ladoB, ladoC);
                double area = CalcularArea(ladoA, ladoB, ladoC, semiperimetro);

                // Mostrar resultados en los TextBox correspondientes
                Txt_semiperimetro.Text = semiperimetro.ToString("F2");
                Txt_area.Text = area.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón "Calcular Semiperímetro"
        private void Btn_semiperimetro_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los lados del triángulo
                double ladoA = double.Parse(Txt_ladoa.Text);
                double ladoB = double.Parse(Txt_ladob.Text);
                double ladoC = double.Parse(Txt_ladoc.Text);

                // Calcular semiperímetro
                double semiperimetro = CalcularSemiperimetro(ladoA, ladoB, ladoC);
                Txt_semiperimetro.Text = semiperimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón "Limpiar"
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_ladoa.Clear();
            Txt_ladob.Clear();
            Txt_ladoc.Clear();
            Txt_semiperimetro.Clear();
            Txt_area.Clear();
        }

        // Evento para el botón "Salir"
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

