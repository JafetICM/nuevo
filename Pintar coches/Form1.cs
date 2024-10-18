using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoPintarCochesApp
{
    public partial class Form1 : Form
    {
        private Queue<Coche> colaCoches;
        private List<Coche> cochesPintados;
        private int contadorCoches;

        public Form1()
        {
            InitializeComponent();
            colaCoches = new Queue<Coche>();
            cochesPintados = new List<Coche>();
            contadorCoches = 1;

            // Colores disponibles en el juego
            cmbColores.Items.AddRange(new string[] { "Rojo", "Verde", "Azul", "Amarillo", "Naranja", "Morado" });
        }

        private void btnAgregarCoche_Click(object sender, EventArgs e)
        {
            if (cmbColores.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un color para el coche.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un nuevo coche y agregarlo a la cola
            string colorRequerido = cmbColores.SelectedItem.ToString();
            Coche nuevoCoche = new Coche(contadorCoches, colorRequerido);
            colaCoches.Enqueue(nuevoCoche);
            contadorCoches++;

            // Actualizar vista de la cola
            ActualizarCola();
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            if (colaCoches.Count == 0)
            {
                MessageBox.Show("No hay coches en la cola para pintar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbColores.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un color para pintar el coche.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pintar el primer coche en la cola
            Coche cocheActual = colaCoches.Dequeue();
            string colorSeleccionado = cmbColores.SelectedItem.ToString();

            if (cocheActual.ColorRequerido == colorSeleccionado)
            {
                cocheActual.Estado = "Pintado";
                cochesPintados.Add(cocheActual);
                MessageBox.Show($"¡Coche {cocheActual.NumeroCoche} pintado correctamente en {colorSeleccionado}!");
            }
            else
            {
                cocheActual.Estado = "Enfriándose";
                MessageBox.Show($"El coche {cocheActual.NumeroCoche} no fue pintado correctamente. Debe enfriarse.");
            }

            // Actualizar vista
            ActualizarCola();
            ActualizarCochesPintados();
        }

        private void ActualizarCola()
        {
            lstCola.Items.Clear();

            foreach (var coche in colaCoches)
            {
                lstCola.Items.Add(coche.ToString());
            }
        }

        private void ActualizarCochesPintados()
        {
            lstPintados.Items.Clear();

            foreach (var coche in cochesPintados)
            {
                lstPintados.Items.Add(coche.ToString());
            }
        }
    }
}
