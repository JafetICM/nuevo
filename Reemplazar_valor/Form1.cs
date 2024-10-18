using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReemplazarValorEnPilaApp
{
    public partial class Form1 : Form
    {
        private List<int> miLista;

        public Form1()
        {
            InitializeComponent();
            miLista = new List<int>(); // Inicializar la pila vacía
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int nuevoNumero;
            if (int.TryParse(txtNumero.Text, out nuevoNumero))
            {
                miLista.Add(nuevoNumero);
                lblResultado.Text = $"Número agregado: {nuevoNumero}\nPila actual: {string.Join(", ", miLista)}";
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNumero.Clear();
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            int viejo, nuevo;

            // Validar las entradas
            if (!int.TryParse(txtViejo.Text, out viejo) || !int.TryParse(txtNuevo.Text, out nuevo))
            {
                MessageBox.Show("Ingrese valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar a la función para reemplazar el valor
            Reemplazar(miLista, viejo, nuevo);

            // Mostrar el resultado
            lblResultado.Text = $"Pila modificada: {string.Join(", ", miLista)}";
        }

        // Función para reemplazar el valor en la lista
        private void Reemplazar(List<int> lista, int viejo, int nuevo)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == viejo)
                {
                    lista[i] = nuevo;
                }
            }
        }
    }
}
