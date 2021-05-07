using System;
using System.Text.RegularExpressions;
using TareaIndividual9_Pilas.Pilas_Arreglos;
using TareaIndividual9_Pilas.Pilas_List;
using TareaIndividual9_Pilas.Pilas_ListaEnlazadaSimple.PilaLineal;
using TareaIndividual9_Pilas.Pilas_ListaEnlazadaSimple.PilaLista;

namespace TareaIndividual9_Pilas
{
    class Program
    {
        //****************EJERCICIOS DE PILA *******************

        //Ejercicios de Pila Lineal usando arreglos
        static void EjemploPilaLineal_Arreglos()
        {
            Arreglo_PilaLineal pila;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese números, y para terminar -1");

            try
            {
                pila = new Arreglo_PilaLineal();

                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pila.insertar(x);
                    }

                } while (x != CLAVE);

                Console.WriteLine("Estos son los elemtos de la pila");

                //Desapila
                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento:{x}");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error" + error.Message);
            }
        }
        //Ejercicio de Pila Lineal usando Lista Enlazada Simple
        static void EjemploPilaLineal_ListaEnlazada()
        {
            clsPilaLineal pilaLineal;
            int x;
            int clave = -1;

            Console.WriteLine("Ingrese los números y para terminar -1");

            try
            {
                pilaLineal = new clsPilaLineal();

                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pilaLineal.insertarNodo(x);
                    }
                } while (x != clave);

                Console.WriteLine("Estos son los elementos de la pila: ");

                pilaLineal.desplegarPila();

            }
            catch (Exception error)
            {
                Console.WriteLine("Error :" + error.Message);
            }
        }
        //Ejercicio de Pila Lineal usando <List>
        static void EjemploPilaLineal_List() 
        {
            clsPilaLineal_Lista pila;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese números y para terminar ingrese -1");
            try
            {
                pila = new clsPilaLineal_Lista();

                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pila.insertar(x);
                    }

                } while (x != CLAVE);

                Console.WriteLine("Estos son los elemtos de la pila");

                //Desapila
                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento:{x}");
                }
            } 
            catch (Exception error) 
            {
                Console.WriteLine("Error" + error.Message);
            }
        }

       //********************Ejercicios Palindromo***********************
        //Ejercicio de Palíndromo usando Arreglos
        static void Palindromo_Arreglos()
        {
            Arreglo_PilaLineal pilaChar;
            bool esPalindromo;
            String pal;

            try
            {

                pilaChar = new Arreglo_PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es palindromo");
                pal = Console.ReadLine();
                String sinTilde = Regex.Replace(pal.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-0]+", "");
                sinTilde = sinTilde.Replace(" ", "");
                Console.WriteLine("Palabra sin tildes : " + sinTilde);
                Console.WriteLine("Nueva cadena de texto sin espacios : " + sinTilde);

                //Creamos la pila con los chars
                for (int i = 0; i < sinTilde.Length;)
                {
                    //Insertamos el caracter, agarrando letra por letra
                    char c;
                    c = sinTilde[i++];
                    pilaChar.insertar(c);
                }

                //Comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    char c;
                    //Extraer uno a uno
                    c = (char)pilaChar.quitarChar();
                   // Console.WriteLine("Valor c: " + c);
                    esPalindromo = sinTilde[j++] == c; //Evalúa si la pos es igual
                   // Console.WriteLine("Sin Tilde: " + sinTilde);
                }
                pilaChar.LimpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {sinTilde} es palindromo");
                }
                else
                {
                    Console.WriteLine($"NEl no ees");
                }

                //Prueba :

            }
            catch (Exception error)
            {
                Console.WriteLine($"error{error.Message}");
            }
        }

        //Ejercicio de Palíndromo usando Lista Enlazada Simple
        static void Palindromo_ListaEnlazada() 
        {
            clsPilaLineal pilaChar;
            bool esPalindromo;
            String pal;


            try
            {
                pilaChar = new clsPilaLineal();
                Console.WriteLine("Teclee una palabra para ser ver si es palíndromo: ");
                pal = Console.ReadLine();
                String sinTilde = Regex.Replace(pal.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-0]+", "");
                Console.WriteLine("Palabra sin tildes : " + sinTilde);
                sinTilde = sinTilde.Replace(" ", "");
                Console.WriteLine("Nueva cadena de texto sin espacios : " + sinTilde);

                for (int i = 0; i < sinTilde.Length;)
                {
                    //Insertamos el caracter, agarrando letra por letra
                    char c;
                    c = sinTilde[i++];
                    pilaChar.insertarNodo(c);
                }

                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    char c;
                    //Extraer uno a uno
                    c = (char)pilaChar.quitarChar();
                    //Console.WriteLine("Valor c: " + c);
                    esPalindromo = sinTilde[j++] == c; //Evalúa si la pos es igual
                }

                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {sinTilde} es palindromo");
                }
                else
                {
                    Console.WriteLine($"NEl no ees");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"error{error.Message}");
            }
        }

        //Ejercicio de Palíndromo usando <List>
        static void Palindromo_List() 
        {
            clsPilaLineal_Lista pilaChar;
            bool esPalindromo;
            String pal;

            try
            {
                pilaChar = new clsPilaLineal_Lista();
                Console.WriteLine("Teclee una palabra para ver si es palindromo");
                pal = Console.ReadLine();
                String sinTilde = Regex.Replace(pal.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-0]+", "");
                sinTilde = sinTilde.Replace(" ", "");
                Console.WriteLine("Palabra sin tildes : " + sinTilde);
                Console.WriteLine("Nueva cadena de texto sin espacios : " + sinTilde);

                //Creamos la pila con los chars
                for (int i = 0; i < sinTilde.Length;)
                {
                    //Insertamos el caracter, agarrando letra por letra
                    char c;
                    c = sinTilde[i++];
                    pilaChar.insertar(c);
                }

                //Comprueba si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    char c;
                    //Extraer uno a uno
                    c = (char)pilaChar.quitarChar();
                  //  Console.WriteLine("Valor c: " + c);
                    esPalindromo = sinTilde[j++] == c; //Evalúa si la pos es igual
                    Console.WriteLine("Sin Tilde: " + sinTilde);
                }
                
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {sinTilde} es palindromo");
                }
                else
                {
                    Console.WriteLine($"NEl no ees");
                }
            } 
            catch (Exception error) 
            {
                Console.WriteLine($"error{error.Message}");
            }
        }

        //***********************Tercer Ejercicio*****************
        //Ejemplo de Pila Lista con Arreglos
        static void EjemploPilaLista_Arreglos() 
        {
            Arreglo_PilaLista pl = new Arreglo_PilaLista();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(217);

            var xx = pl.quitar();
        }

        //Ejemplo de Pila Lista con Lista Enlazada
        static void EjemploPilaLista_ListaEnlazada() 
        {
            pilaLista pl = new pilaLista();
            pl.insertarNodo(1);
            pl.insertarNodo(5);
            pl.insertarNodo(16);
            pl.insertarNodo(217);

             pl.quitar();
        }

        //Ejemplo de Pila Lista con <List>
        static void EjemploPilaLista_List() 
        {
            clsPilaLista_List pl = new clsPilaLista_List();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(217);

            Console.WriteLine("Los datos son : " + pl);

            var xx = pl.quitar();
        }
        
        //Evaluación de Expresiones Matemáticas
        static void Expresiones_Matematicas() 
        {
            Arreglo_PilaLineal miPila = new Arreglo_PilaLineal();
            int n = 0;
            int r = 0;
            int a = 0;
            int b = 0;
            Object x;
            char caracter = ' ';
            
            Console.WriteLine("Ingrese la expresión matemática en PREFIX");
            String expresion = Console.ReadLine();

            for(n = expresion.Length-1; n >= 0; n--) 
            {
                caracter = expresion[n];

                if(caracter >= '0' && caracter <= '9') 
                {
                    miPila.insertar(Convert.ToInt32(caracter.ToString()));
                }
                else 
                {
                    a = (int)miPila.quitar();
                    b = (int)miPila.quitar();

                    if(caracter == '+') 
                    {
                        r = a + b;
                        miPila.insertar(r);
                    }
                    if(caracter == '-') 
                    {
                        r = a - b;
                        miPila.insertar(r);
                    }
                    if(caracter == '/') 
                    {
                        r = a / b;
                        miPila.insertar(r);
                    }
                    if(caracter == '*') 
                    {
                        r = a * b;
                        miPila.insertar(r);
                    }
                }
            }

            //Despliega la pila y muestra el resultado de la expresión
            Console.WriteLine("Este es el resultado de la expresión: ");
            //Desapila
            while (!miPila.pilaVacia())
            {
                x = miPila.quitar();
                Console.WriteLine($"elemento:{x}");
            }
        }
        static void Main(string[] args)
        {
           // EjemploPilaLineal_Arreglos();
            // EjemploPilaLineal_ListaEnlazada();
           // EjemploPilaLineal_List();


          //  Palindromo_Arreglos();
            //Palindromo_ListaEnlazada();
          //  Palindromo_List();


            //EjemploPilaLista_Arreglos();
          //EjemploPilaLista_ListaEnlazada();
            //EjemploPilaLista_List();

            Expresiones_Matematicas();
        }

    }
}


