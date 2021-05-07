using System;
using System.Collections.Generic;
using System.Text;

namespace TareaIndividual9_Pilas.Pilas_ListaEnlazadaSimple.PilaLista
{
  public  class pilaLista
  {
        //Indicará la cima de la pila
        private clsNodo_lista primero;
        Object ultimoNodo;
        int size = -1;


        public pilaLista()
        {
            primero = null;
        }

        public bool pilaVacia()
        {
            return primero == null;
        }

        public bool pilaLlena()
        {
            return primero != null;
        }

        //Inserta los datos a nuestra pila.
        public void insertarNodo(Object elemento)
        {
            clsNodo_lista Nuevo = new clsNodo_lista();
            Nuevo.Dato = elemento;

            Nuevo.Siguiente = primero;
            primero = Nuevo;
            Console.WriteLine("Nodo insertado :)");
            size++;
        }

        public void buscarNodo()
        {
            //Recorre la pila desde el primero
            clsNodo_lista Actual = new clsNodo_lista();
            Actual = primero;
            bool encontrado = false;

            Console.WriteLine("Ingrese el dato del nodo a buscar: ");
            Object nodoBuscado = int.Parse(Console.ReadLine());

            if (primero != null)
            {
                while (Actual != null && encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("Nodo con el dato{0} : Ecnontrado" + nodoBuscado);
                    }
                    Actual = Actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("Nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine("La Pila se encuentra vacía :(");
            }
        }

        public Object primerNodo()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return primero;
        }


        //Recorre la pila y la despliega.
        public void desplegarPila()
        {
            //Recorre la pila desde el primero
            clsNodo_lista Actual = new clsNodo_lista();
            Actual = primero;

            if (primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("La Pila se encuentra vacía :(");
            }
        }//Fin de desplegarPila

        public Object quitarChar()
        {
            Object aux;
            clsNodo_lista Actual = new clsNodo_lista();

            if (pilaVacia())
            {
                Console.WriteLine("Nel está vacía");
            }

            aux = primero.Dato;
            primero = primero.Siguiente;

            return aux;
        }

        public void LimpiarPila()
        {
            primero = null;
        }



        public void quitar()
        {
            if (primero == null)
            {
                Console.WriteLine("Lista vacía, no se puede quitar");
            }
            else
            {
                primero = primero.Siguiente;
            }
            size--;
        }
    }
}
