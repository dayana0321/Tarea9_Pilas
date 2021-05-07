using System;
using System.Collections.Generic;
using System.Text;

namespace TareaIndividual9_Pilas.Pilas_ListaEnlazadaSimple.PilaLineal
{
    class NodoLineal
    {
        private Object dato;
        private NodoLineal siguiente;

        public Object Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoLineal Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
