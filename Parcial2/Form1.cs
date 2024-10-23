using System;
using System.Globalization;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convertir_altura_Click(object sender, EventArgs e)
        {
            // Reemplaza la coma por punto antes de intentar convertir
            string alturaInput = txt_altura_ft.Text.Replace(',', '.');
            if (double.TryParse(alturaInput, NumberStyles.Any, CultureInfo.InvariantCulture, out double alturaFt))
            {
                double alturaMts = alturaFt * 0.3048;
                txt_altura_mts.Text = alturaMts.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese una altura válida en pies.");
            }
        }

        private void btn_convertir_peso_Click(object sender, EventArgs e)
        {
            // Reemplaza la coma por punto antes de intentar convertir
            string pesoInput = txt_peso_lb.Text.Replace(',', '.');
            if (double.TryParse(pesoInput, NumberStyles.Any, CultureInfo.InvariantCulture, out double pesoLb))
            {
                double pesoKg = pesoLb * 0.453592;
                txt_peso_kg.Text = pesoKg.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese un peso válido en libras.");
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Reemplaza la coma por punto antes de intentar convertir
            string alturaInput = txt_altura_mts.Text.Replace(',', '.');
            string pesoInput = txt_peso_kg.Text.Replace(',', '.');

            if (double.TryParse(alturaInput, NumberStyles.Any, CultureInfo.InvariantCulture, out double alturaMts) &&
                double.TryParse(pesoInput, NumberStyles.Any, CultureInfo.InvariantCulture, out double pesoKg))
            {
                double imc = pesoKg / (alturaMts * alturaMts);

                // Mostrar el IMC en el TextBox `txt_diferencia`
                txt_diferencia.Text = imc.ToString("F2");

                // Obtener categoría y mostrarla en `txt_categoria`
                string categoria = ObtenerCategoriaIMC(imc);
                txt_categoria.Text = categoria;

                // Registrar solo el IMC y la categoría en el ListBox
                string registro = $"{imc:F2} {categoria}";
                lst_registro.Items.Add(registro);
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para la altura y el peso.");
            }
        }

        private string ObtenerCategoriaIMC(double imc)
        {
            if (imc < 18.5) return "Bajo peso";
            else if (imc < 24.9) return "Normal";
            else if (imc < 29.9) return "Sobrepeso";
            else return "Obesidad";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox y ListBox
            txt_altura_ft.Clear();
            txt_altura_mts.Clear();
            txt_peso_lb.Clear();
            txt_peso_kg.Clear();
            txt_categoria.Clear();
            txt_diferencia.Clear();
            lst_registro.Items.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }
    }
}




