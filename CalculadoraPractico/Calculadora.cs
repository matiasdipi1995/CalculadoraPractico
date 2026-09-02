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
                string texto = txtPantalla.Text;

                // Validamos que la pantalla no esté vacía ni contenga solo espacios
                if (string.IsNullOrWhiteSpace(texto)) return;

                // Instanciamos DataTable para evaluar la expresión
                DataTable dt = new DataTable();

                // Compute evalúa la cadena respetando la jerarquía de operadores
                object resultadoObjeto = dt.Compute(texto, null);

                // Convertimos el resultado a double
                double resultado = Convert.ToDouble(resultadoObjeto);

                // Mostramos el resultado en pantalla
                txtPantalla.Text = resultado.ToString();
            }
            catch (Exception)
            {
                txtPantalla.Text = "Error";
            }
        }
    }
}