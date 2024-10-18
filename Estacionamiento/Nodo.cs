namespace EstacionamientoApp
{
    public class Nodo
    {
        public Auto Auto { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Auto auto)
        {
            Auto = auto;
            Anterior = null;
            Siguiente = null;
        }
    }
}
