using System;
using System.Collections.Generic;
using System.Text;

namespace TareaIndividual9_Pilas.Pilas_Arreglos
{
    class Arreglo_PilaLineal
    {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] ListaPila;

        public Arreglo_PilaLineal()
        {
            cima = -1;//Condición de pila vacía 
            ListaPila = new Object[TAMPILA];
        }

        public bool pilaLlena()
        {
            return cima == (TAMPILA - 1);
        }
        //Operaciones que modifican la pila

        public void insertar(Object elemento)
        {
            if (pilaLlena())
            {
                throw new Exception("Desbordamiento de pila Stack Overflow");
            }

            //Incrementar puntero cima y vamos a insertar el elemento
            cima++;
            ListaPila[cima] = elemento;
        }//Fin insertar

        public bool pilaVacia()
        {
            return cima == -1;
        }

        //Retorna un tipo CHAR
        public Object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacía, no hay data");
            }
            aux = (char)ListaPila[cima];
            cima--;
            return aux;
        }

        //Extraer elemento de la pila (POP)

        public Object quitar()
        {
            Object aux;

            if (pilaVacia())
            {
                throw new Exception("La pila está vacía, no se puede sacar");
            }

            //Guardar el elemento 
            //Si fuera String cambiar el int
            aux = (int)ListaPila[cima];


            //Decrementar el valor de cima y retornar el elemento
            cima--;
            return aux;
        }//Fin quitar

        public void LimpiarPila()
        {
            cima = -1;
        }

        //Operacion de acceso a la pila

        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacía");

            }
            return ListaPila[cima];
        }
    }
}
