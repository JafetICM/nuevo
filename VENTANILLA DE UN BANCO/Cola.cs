using System;
using System.Collections.Generic;

namespace VentanillaBancoApp
{
    public class ColaClientes
    {
        private Nodo primero;
        private Nodo ultimo;

        public ColaClientes()
        {
            primero = null;
            ultimo = null;
        }

        public bool EstaVacia()
        {
            return primero == null;
        }

        public void Encolar(Cliente cliente)
        {
            Nodo nuevoNodo = new Nodo(cliente);
            if (EstaVacia())
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo;
            }
            else
            {
                ultimo.Siguiente = nuevoNodo;
                ultimo = nuevoNodo;
            }
        }

        public Cliente Desencolar()
        {
            if (EstaVacia())
            {
                return null;
            }

            Cliente clienteAtendido = primero.Cliente;
            primero = primero.Siguiente;
            if (primero == null)
            {
                ultimo = null;
            }

            return clienteAtendido;
        }

        public Cliente Frente()
        {
            return EstaVacia() ? null : primero.Cliente;
        }

        public Cliente Final()
        {
            return EstaVacia() ? null : ultimo.Cliente;
        }

        public IEnumerable<Cliente> ObtenerTodos()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                yield return actual.Cliente;
                actual = actual.Siguiente;
            }
        }
    }
}
