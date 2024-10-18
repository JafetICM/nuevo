using System;

namespace EstacionamientoApp
{
    public class ColaCircularDoble
    {
        private Nodo frente;
        private Nodo final;

        public ColaCircularDoble()
        {
            frente = null;
            final = null;
        }

        // Verifica si la cola está vacía
        public bool ColaVacia()
        {
            return frente == null;
        }

        // Inserta un nuevo nodo en la cola
        public void Insertar(Auto auto)
        {
            Nodo nuevoNodo = new Nodo(auto);

            if (ColaVacia())
            {
                frente = nuevoNodo;
                final = nuevoNodo;
                frente.Siguiente = frente;
                frente.Anterior = frente;
            }
            else
            {
                nuevoNodo.Anterior = final;
                nuevoNodo.Siguiente = frente;
                final.Siguiente = nuevoNodo;
                frente.Anterior = nuevoNodo;
                final = nuevoNodo;
            }
        }

        // Elimina el primer nodo de la cola
        public Nodo Eliminar()
        {
            if (ColaVacia())
            {
                return null;
            }
            else if (frente == final)
            {
                Nodo nodoEliminar = frente;
                frente = null;
                final = null;
                return nodoEliminar;
            }
            else
            {
                Nodo nodoEliminar = frente;
                frente = frente.Siguiente;
                final.Siguiente = frente;
                frente.Anterior = final;
                return nodoEliminar;
            }
        }

        // Muestra el primer nodo de la cola
        public Nodo MostrarFrente()
        {
            return frente;
        }
    }
}
