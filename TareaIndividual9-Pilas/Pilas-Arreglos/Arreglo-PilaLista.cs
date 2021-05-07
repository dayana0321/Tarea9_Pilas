using System;
using System.Collections.Generic;
using System.Text;

namespace TareaIndividual9_Pilas.Pilas_Arreglos
{
   public class Arreglo_PilaLista
   {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] listaPila;

        public Arreglo_PilaLista()
        {
            cima = -1; // condicion de pila vacia.
            listaPila = new Object[TAMPILA];
        }
        public bool pilaLlena()
        {
            return cima == (TAMPILA - 1);
        }
      
        public void insertar(Object elemento)
        {
            if (pilaLlena())
            {
                throw new Exception("Desbordamiento de pila Stack Overflow");
            }

            //Incrementar puntero cima y vamos a insertar el elemento
            cima++;
            listaPila[cima] = elemento;
        }
        public bool arregloVacio()
        {
            return cima == -1;
        }
        public Object quitarChar()
        {
            char aux;
            if (arregloVacio())
            {
                throw new Exception("Pila vacía, no hay data");
            }
            aux = (char)listaPila[cima];
            cima--;
            return aux;
        }

        public Object quitar()
        {
            int aux;

            if (arregloVacio())
            {
                throw new Exception("La pila está vacía, no se puede sacar");
            }

            //Guardar el elemento 
            //Si fuera String cambiar el int
            aux = (int)listaPila[cima];


            //Decrementar el valor de cima y retornar el elemento
            cima--;
            return aux;
        }
        public void LimpiarPila()
        {
            cima = -1;
        }


        public Object cimaPila()
        {
            if (arregloVacio())
            {
                throw new Exception("Pila vacía");

            }
            return listaPila[cima];
        }

      

        public void limpiarPila()
        {
            while (!arregloVacio())
            {
                quitar();
            }
        }
    }
}
