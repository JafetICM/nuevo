using System;


namespace VentanillaBancoApp
{
    public class Cliente
    {
        public int NumeroTurno { get; set; }
        public string Nombre { get; set; }
        public string Movimiento { get; set; }
        public DateTime HoraLlegada { get; set; }

        public Cliente(int numeroTurno, string nombre, string movimiento)
        {
            NumeroTurno = numeroTurno;
            Nombre = nombre;
            Movimiento = movimiento;
            HoraLlegada = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Turno: {NumeroTurno}, Nombre: {Nombre}, Movimiento: {Movimiento}, Hora: {HoraLlegada}";
        }
    }
}
