using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// nan concatena, contanetalos operadores, no debe arrancar con operadores <= Listo solucionado
// no debe arrancar con parentesis cerrados, agregar el porcentaje.

namespace CalculadoraPractico
{
    public partial class Calculadora : Form
    {
        int contador = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void forms_Load(object sender, EventArgs e)
        {

        }

        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            string textoBoton = boton.Text;
            string textoPantalla = txtPantalla.Text;

            // 1. Si la pantalla muestra un error previo, la limpiamos
            if (textoPantalla == "Error" || textoPantalla == "NaN" || textoPantalla == "Infinity")
            {
                txtPantalla.Text = "";
                textoPantalla = "";
            }

            // ==========================================
            // CASO 1: El botón presionado es ')'
            // ==========================================
            if (textoBoton == ")")
            {
                if (string.IsNullOrWhiteSpace(textoPantalla)) return;
                if (EsOperador(textoPantalla[textoPantalla.Length - 1])) return;
                if (textoPantalla[textoPantalla.Length - 1] == '(') return;

                int parentesisAbiertos = textoPantalla.Count(c => c == '(');
                int parentesisCerrados = textoPantalla.Count(c => c == ')');

                if (parentesisAbiertos > parentesisCerrados)
                {
                    txtPantalla.Text += ")";
                }
                return;
            }

            // ==========================================
            // CASO 2: El botón presionado es '%'
            // ==========================================
            else if (textoBoton == "%")
            {
                if (string.IsNullOrWhiteSpace(textoPantalla)) return;

                char ultimo = textoPantalla[textoPantalla.Length - 1];
                // No se puede poner '%' tras un operador, un '(' u otro '%'
                if (EsOperador(ultimo) || ultimo == '(' || ultimo == '%') return;

                txtPantalla.Text += "%";
                return;
            }

            // ==========================================
            // CASO 3: El botón presionado es un OPERADOR (+, -, x, /)
            // ==========================================
            else if (EsOperador(textoBoton[0]))
            {
                if (string.IsNullOrWhiteSpace(textoPantalla)) return;

                // Si el último carácter es un operador, REEMPLAZA
                if (EsOperador(textoPantalla[textoPantalla.Length - 1]))
                {
                    txtPantalla.Text = textoPantalla.Substring(0, textoPantalla.Length - 1) + textoBoton;
                }
                else
                {
                    txtPantalla.Text += textoBoton;
                }
                return;
            }

            // ==========================================
            // CASO 4: El botón presionado es '('
            // ==========================================
            else if (textoBoton == "(")
            {
                // Si el último carácter es un número, ')' o '%', inserta 'x('
                if (textoPantalla.Length > 0 &&
                   (char.IsDigit(textoPantalla[textoPantalla.Length - 1]) ||
                    textoPantalla[textoPantalla.Length - 1] == ')' ||
                    textoPantalla[textoPantalla.Length - 1] == '%'))
                {
                    txtPantalla.Text += "x(";
                }
                else
                {
                    txtPantalla.Text += "(";
                }
                return;
            }
            
            // ==========================================
            // CASO 6: El botón presionado es NÚMERO (0-9) o Punto (.)
            // ==========================================
            else
            {
                // Si la pantalla termina en ')' o '%', inserta 'x' antes del número
                if (textoPantalla.Length > 0 &&
                   (textoPantalla[textoPantalla.Length - 1] == ')' || textoPantalla[textoPantalla.Length - 1] == '%'))
                {
                    txtPantalla.Text += "x" + textoBoton;
                }
                else
                {
                    txtPantalla.Text += textoBoton;
                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = ""; // Limpia la pantalla por completo
            if (lblResultadoPrevio != null) lblResultadoPrevio.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            // Verificamos que la pantalla no esté vacía antes de borrar
            if (txtPantalla.Text.Length > 0)
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string operacionIngresada = txtPantalla.Text;

                // 1. Evitamos procesar si la pantalla está vacía o muestra un error previo
                if (string.IsNullOrWhiteSpace(operacionIngresada) ||
                    operacionIngresada == "Error" ||
                    operacionIngresada == "NaN") return;

                // 2. Normalizamos la cadena: reemplazamos 'x'/'X' por '*' y '%' por '/100'
                // Normalizamos la cadena para que DataTable.Compute la entienda
                string operacionNormalizada = operacionIngresada
                    .Replace(",", ".")
                    .Replace("x", "*")
                    .Replace("X", "*")
                    .Replace("%", "/100.0");
                    

                // 2. Cerramos automáticamente los paréntesis pendientes (ej: Sqrt(2  ->  Sqrt(2))
                int abiertos = operacionNormalizada.Count(c => c == '(');
                int cerrados = operacionNormalizada.Count(c => c == ')');

                while (cerrados < abiertos)
                {
                    operacionNormalizada += ")";
                    cerrados++;
                }

                DataTable dt = new DataTable();
                object resultadoObjeto = dt.Compute(operacionNormalizada, null);
                double resultado = Convert.ToDouble(resultadoObjeto);

                // 3. Validamos divisiones por cero u operaciones matemáticas indefinidas
                if (double.IsNaN(resultado) || double.IsInfinity(resultado))
                {
                    txtPantalla.Text = "Error";
                    lblResultadoPrevio.Text = "";
                    return;
                }

                // 4. Guardamos en el historial y enfocamos el último elemento
                lstHistorial.Items.Add($"{operacionIngresada} = {resultado}");
                lstHistorial.TopIndex = lstHistorial.Items.Count - 1;

                // 5. Mostramos el resultado y limpiamos la vista previa
                txtPantalla.Text = resultado.ToString();
                lblResultadoPrevio.Text = "";
            }
            catch (Exception)
            {
                txtPantalla.Text = "Error";
                lblResultadoPrevio.Text = "";
            }
        }

        // EVENTO: Se ejecuta automáticamente cada vez que la pantalla cambia de texto
        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {
            CalcularEnTiempoReal();
        }

        // MÉTODO AUXILIAR: Evalúa la operación mientras el usuario la va escribiendo
        private void CalcularEnTiempoReal()
        {
            try
            {
                string texto = txtPantalla.Text;

                // Si la pantalla está vacía o el último carácter ingresado es un operador (+, -, *, /),
                // no intentamos calcular todavía para evitar excepciones.
                if (string.IsNullOrWhiteSpace(texto) || EsOperador(texto[texto.Length - 1]))
                {
                    lblResultadoPrevio.Text = "";
                    return;
                }

                DataTable dt = new DataTable();
                object resultadoObjeto = dt.Compute(texto, null);
                double resultado = Convert.ToDouble(resultadoObjeto);

                // Mostramos el resultado tentativo en el Label sin modificar el TextBox
                lblResultadoPrevio.Text = "= " + resultado.ToString();
            }
            catch
            {
                // Mientras la expresión esté incompleta (ej: paréntesis sin cerrar),
                // ignoramos los errores y dejamos el label vacío temporalmente.
                lblResultadoPrevio.Text = "";
            }
        }

        // Función que ayuda a identificar si un carácter es un operador básico
        private bool EsOperador(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/'|| c == 'x';
        }

        private void txtPantalla_TextChanged_1(object sender, EventArgs e)
        {
            CalcularEnTiempoReal();
        }
    }
}