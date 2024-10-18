using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SumaNumerosGrandesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string numero1 = txtNumero1.Text.Trim();
            string numero2 = txtNumero2.Text.Trim();

            if (string.IsNullOrWhiteSpace(numero1) || string.IsNullOrWhiteSpace(numero2))
            {
                MessageBox.Show("Por favor, ingrese ambos números para realizar la suma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que ambos números sean enteros positivos
            if (!EsNumeroValido(numero1) || !EsNumeroValido(numero2))
            {
                MessageBox.Show("Ingrese números válidos (sólo dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear listas para almacenar los dígitos
            List<int> lista1 = ConvertirCadenaALista(numero1);
            List<int> lista2 = ConvertirCadenaALista(numero2);

            // Realizar la suma de las listas
            string resultado = SumarListas(lista1, lista2);

            // Mostrar el resultado
            lblResultado.Text = $"Resultado: {resultado}";
        }

        private List<int> ConvertirCadenaALista(string numero)
        {
            List<int> lista = new List<int>();

            foreach (char digito in numero)
            {
                lista.Add(int.Parse(digito.ToString()));
            }

            // Invertimos la lista para facilitar la suma desde las unidades
            lista.Reverse();

            return lista;
        }

        private string SumarListas(List<int> lista1, List<int> lista2)
        {
            List<int> listaResultado = new List<int>();
            int acarreo = 0;
            int maxLength = Math.Max(lista1.Count, lista2.Count);

            for (int i = 0; i < maxLength || acarreo > 0; i++)
            {
                int suma = acarreo;

                if (i < lista1.Count)
                {
                    suma += lista1[i];
                }

                if (i < lista2.Count)
                {
                    suma += lista2[i];
                }

                listaResultado.Add(suma % 10);  // Guardar el dígito de las unidades
                acarreo = suma / 10;  // Calcular el acarreo
            }

            // Invertimos la lista de resultado para mostrar el número correctamente
            listaResultado.Reverse();

            // Convertimos la lista a una cadena para mostrar el resultado
            return string.Join("", listaResultado);
        }

        private bool EsNumeroValido(string numero)
        {
            foreach (char c in numero)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
