using System;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = ""; // Guarda el operador (+, -, /, ^, etc.)
        private bool isRootOperation = false; // Marca si la última operación es raíz
        private string currentOperation = ""; // Guarda la operación completa como texto

        public Form1()
        {
            InitializeComponent();
        }

        // Método para manejar los clics de los botones numéricos
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txt_operation.Text += button.Text; // Muestra el número en la operación
            currentOperation += button.Text; // Agrega el número a la operación completa
        }

        // Método para manejar las operaciones
        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!string.IsNullOrWhiteSpace(txt_operation.Text))
            {
                firstNumber = GetCurrentValue(); // Guarda el primer número
                operation = button.Text; // Guarda el operador actual
                txt_operation.Text += " " + operation + " "; // Muestra el operador en la operación
                currentOperation += " " + operation + " "; // Agrega el operador a la operación completa
            }
        }

        // Método para el botón "="
        private void btn_equals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_operation.Text))
            {
                return; // Evita cálculos si no hay operación
            }

            try
            {
                // Usa DataTable para evaluar la expresión matemática completa
                var dt = new System.Data.DataTable();
                var result = dt.Compute(currentOperation, "");
                txt_result.Text = result.ToString(); // Muestra el resultado
                currentOperation = ""; // Reinicia la operación completa
            }
            catch (Exception ex)
            {
                txt_result.Text = "Error"; // Muestra un error si la expresión es inválida
            }
        }

        // Método para obtener el valor actual
        private double GetCurrentValue()
        {
            string value = txt_operation.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Last();
            if (value.Equals("pi", StringComparison.OrdinalIgnoreCase))
            {
                return Math.PI; // Retorna el valor de pi
            }

            double number;
            if (double.TryParse(value, out number))
            {
                return number; // Retorna el número parseado
            }

            return 0; // En caso de que no sea un número válido
        }

        // Método para manejar el botón de pi
        private void btn_pi_Click(object sender, EventArgs e)
        {
            txt_operation.Text += "pi"; // Agrega 'pi' al texto de la operación
            currentOperation += "pi"; // Agrega 'pi' a la operación completa
        }

        // Método para manejar el botón de exponente
        private void btn_exponent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_operation.Text))
            {
                firstNumber = GetCurrentValue(); // Obtiene el primer número
                operation = "exp"; // Asigna el operador de exponente
                txt_operation.Text += " ^ "; // Muestra el símbolo de exponente en la operación
                currentOperation += " ^ "; // Agrega el operador de exponente a la operación completa
            }
        }

        // Método para manejar el botón de raíz cuadrada
        private void btn_root_Click(object sender, EventArgs e)
        {
            txt_operation.Text += "raíz "; // Agrega 'raíz' al texto de la operación
            isRootOperation = true; // Marca que la operación es raíz
            // No se realiza ningún cálculo aquí
        }

        // Método para manejar el botón de porcentaje
        private void btn_porcent_Click(object sender, EventArgs e)
        {
            // Verifica que haya un número en el cuadro de texto
            if (!string.IsNullOrWhiteSpace(txt_operation.Text))
            {
                // Obtiene el número actual (número al que se va a aplicar el porcentaje)
                double number = GetCurrentValue();

                // Si ya existe una operación (ejemplo: 500 *), aplicamos el porcentaje según la operación
                if (!string.IsNullOrWhiteSpace(operation))
                {
                    secondNumber = number; // El número después del operador
                    double resultado = 0;

                    switch (operation)
                    {
                        case "+":
                            // Suma el porcentaje del primer número al primer número
                            resultado = firstNumber + (firstNumber * secondNumber / 100);
                            break;
                        case "-":
                            // Resta el porcentaje del primer número al primer número
                            resultado = firstNumber - (firstNumber * secondNumber / 100);
                            break;
                        case "*":
                            // Multiplica el primer número por el porcentaje del segundo
                            resultado = firstNumber * (secondNumber / 100);
                            break;
                        case "/":
                            // Divide el primer número por el porcentaje del segundo (si no es cero)
                            if (secondNumber != 0)
                            {
                                resultado = firstNumber / (secondNumber / 100);
                            }
                            else
                            {
                                txt_result.Text = "Error"; // Manejo de división por cero
                                return;
                            }
                            break;
                    }

                    // Muestra el resultado en la calculadora
                    txt_result.Text = resultado.ToString();

                    // Actualiza la operación mostrada (opcional)
                    txt_operation.Text += " %"; // Muestra el símbolo de porcentaje en la operación
                }
                else
                {
                    // Si no hay una operación previa, simplemente calcula el porcentaje del número actual
                    double resultado = number / 100;
                    txt_result.Text = resultado.ToString();
                    txt_operation.Text += " %"; // Muestra el símbolo de porcentaje en la operación
                }
            }
        }

        // Método para manejar el botón de punto decimal
        private void btn_point_Click(object sender, EventArgs e)
        {
            // Verifica que el último carácter no sea ya un punto
            if (!txt_operation.Text.EndsWith("."))
            {
                // Verifica si ya hay un número en curso sin un punto
                string[] currentNumber = txt_operation.Text.Split(new char[] { ' ', '+', '-', '*', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                if (currentNumber.Length > 0 && !currentNumber.Last().Contains("."))
                {
                    txt_operation.Text += "."; // Agrega el punto al texto de la operación
                    currentOperation += ".";   // Agrega el punto a la operación completa
                }
            }
        }

        // Método para manejar el botón de abrir paréntesis
        private void btn_open_Click(object sender, EventArgs e)
        {
            txt_operation.Text += "("; // Agrega un paréntesis abierto a la operación
            currentOperation += "(";   // Agrega un paréntesis abierto a la operación completa
        }

        // Método para manejar el botón de cerrar paréntesis
        private void btn_close_Click(object sender, EventArgs e)
        {
            // Solo agrega un paréntesis de cierre si hay un paréntesis de apertura antes
            int openParens = currentOperation.Count(c => c == '(');
            int closeParens = currentOperation.Count(c => c == ')');

            if (openParens > closeParens)
            {
                txt_operation.Text += ")"; // Agrega un paréntesis cerrado
                currentOperation += ")";   // Agrega un paréntesis cerrado a la operación completa
            }
        }

        // Método para el botón "Borrar"
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_operation.Text.Length > 0)
            {
                txt_operation.Text = txt_operation.Text.Remove(txt_operation.Text.Length - 1); // Elimina el último carácter
                currentOperation = currentOperation.Remove(currentOperation.Length - 1); // Elimina de la operación completa
            }
        }

        // Método para limpiar todo
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_operation.Clear();
            txt_result.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            currentOperation = ""; // Limpia la operación completa
            isRootOperation = false; // Reinicia el indicador de operación de raíz
        }
    }
}

