using System;

namespace JuegoPintarCochesApp
{
    public class Coche
    {
        public int NumeroCoche { get; set; }
        public string ColorRequerido { get; set; }
        public DateTime HoraLlegada { get; set; }
        public string Estado { get; set; }  // Estado puede ser: "En Espera", "Pintando", "Enfriándose", "Pintado"

        public Coche(int numero, string colorRequerido)
        {
            NumeroCoche = numero;
            ColorRequerido = colorRequerido;
            HoraLlegada = DateTime.Now;
            Estado = "En Espera";
        }

        public override string ToString()
        {
            return $"Coche {NumeroCoche} - {ColorRequerido} - {Estado}";
        }
    }
}
