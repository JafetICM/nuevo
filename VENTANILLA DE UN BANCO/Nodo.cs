namespace VentanillaBancoApp
{
    public class Nodo
    {
        public Cliente Cliente { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Cliente cliente)
        {
            Cliente = cliente;
            Siguiente = null;
        }
    }
}
