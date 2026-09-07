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

namespace CalculadoraPractico
{
    public partial class Calculadora : Form
    {
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
            txtPantalla.Text += boton.Text;
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

                // Validamos que la pantalla no esté vacía ni contenga solo espacios
                if (string.IsNullOrWhiteSpace(operacionIngresada)) return;

                StringBuilder operacionNormalizada = new StringBuilder(operacionIngresada);

                for (int i = 0; i < operacionNormalizada.Length; i++)
                {
                    if (operacionNormalizada[i] == 'x' )
                    { operacionNormalizada[i] = '*'; }
                }            
               
                // Instanciamos DataTable para evaluar la expresión
                DataTable dt = new DataTable();

                // Compute evalúa la cadena respetando la jerarquía de operadores
                object resultadoObjeto = dt.Compute(operacionNormalizada.ToString(), null);

                // Convertimos el resultado a double
                double resultado = Convert.ToDouble(resultadoObjeto);

                // 1. Guardamos la operación completa en el ListBox del historial
                lstHistorial.Items.Add($"{operacionIngresada} = {resultado}");

                // 2. Mantenemos el scroll del ListBox siempre enfocado en el último elemento
                lstHistorial.TopIndex = lstHistorial.Items.Count - 1;

                // Mostramos el resultado en la pantalla principal
                txtPantalla.Text = resultado.ToString();

                // Limpiamos la vista previa intermedia al presionar el igual
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
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private void txtPantalla_TextChanged_1(object sender, EventArgs e)
        {
            CalcularEnTiempoReal();
        }
    }
}