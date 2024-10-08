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

        // M�todo para calcular el semiper�metro
        private double CalcularSemiperimetro(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA + ladoB + ladoC) / 2;
        }

        // M�todo para calcular el �rea usando la f�rmula de Her�n
        private double CalcularArea(double ladoA, double ladoB, double ladoC, double semiperimetro)
        {
            return Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
        }

        // Evento para el bot�n "Calcular �rea"
        private void Btn_area_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los lados del tri�ngulo
                double ladoA = double.Parse(Txt_ladoa.Text);
                double ladoB = double.Parse(Txt_ladob.Text);
                double ladoC = double.Parse(Txt_ladoc.Text);

                // Calcular semiper�metro y �rea
                double semiperimetro = CalcularSemiperimetro(ladoA, ladoB, ladoC);
                double area = CalcularArea(ladoA, ladoB, ladoC, semiperimetro);

                // Mostrar resultados en los TextBox correspondientes
                Txt_semiperimetro.Text = semiperimetro.ToString("F2");
                Txt_area.Text = area.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores num�ricos v�lidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el bot�n "Calcular Semiper�metro"
        private void Btn_semiperimetro_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los lados del tri�ngulo
                double ladoA = double.Parse(Txt_ladoa.Text);
                double ladoB = double.Parse(Txt_ladob.Text);
                double ladoC = double.Parse(Txt_ladoc.Text);

                // Calcular semiper�metro
                double semiperimetro = CalcularSemiperimetro(ladoA, ladoB, ladoC);
                Txt_semiperimetro.Text = semiperimetro.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores num�ricos v�lidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el bot�n "Limpiar"
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_ladoa.Clear();
            Txt_ladob.Clear();
            Txt_ladoc.Clear();
            Txt_semiperimetro.Clear();
            Txt_area.Clear();
        }

        // Evento para el bot�n "Salir"
        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

