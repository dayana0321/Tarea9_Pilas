using System;
using System.Collections.Generic;
using System.Text;

namespace TareaIndividual9_Pilas.Pilas_ListaEnlazadaSimple.PilaLista
{
    class clsNodo_lista
    {
        private Object dato;
        private clsNodo_lista siguiente;

        public Object Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public clsNodo_lista Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
