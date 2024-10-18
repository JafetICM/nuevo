using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EstacionamientoApp
{
    public partial class Form1 : Form
    {
        // Lista para almacenar los autos estacionados
        private List<Auto> autosEstacionados;

        public Form1()
        {
            InitializeComponent();
            autosEstacionados = new List<Auto>(); // Inicializamos la lista de autos
        }

        // Método para manejar la entrada de autos
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string placas = txtPlacas.Text.Trim();
            string propietario = txtPropietario.Text.Trim();

            if (string.IsNullOrEmpty(placas) || string.IsNullOrEmpty(propietario))
            {
                MessageBox.Show("Por favor, ingrese las placas y el propietario del auto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un nuevo objeto Auto y agregarlo a la lista
            Auto nuevoAuto = new Auto(placas, propietario);
            autosEstacionados.Add(nuevoAuto);

            // Actualizamos la lista visual
            ActualizarLista();

            // Limpiamos los campos de entrada
            txtPlacas.Clear();
            txtPropietario.Clear();
        }

        // Método para manejar la salida de autos
        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (autosEstacionados.Count == 0)
            {
                MessageBox.Show("No hay autos en el estacionamiento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Quitamos el primer auto de la lista (FIFO)
            Auto autoSaliente = autosEstacionados[0];
            autosEstacionados.RemoveAt(0);

            // Mostramos un mensaje de salida
            MessageBox.Show($"El auto con placas {autoSaliente.Placas} de {autoSaliente.Propietario} ha salido del estacionamiento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizamos la lista visual
            ActualizarLista();
        }

        // Método para actualizar la lista de autos en el ListBox
        private void ActualizarLista()
        {
            lstCola.Items.Clear();
            foreach (var auto in autosEstacionados)
            {
                lstCola.Items.Add($"{auto.Placas} - {auto.Propietario}");
            }
        }
    }

    // Clase Auto para representar los autos en el estacionamiento
    public class Auto
    {
        public string Placas { get; set; }
        public string Propietario { get; set; }

        public Auto(string placas, string propietario)
        {
            Placas = placas;
            Propietario = propietario;
        }
    }
}
