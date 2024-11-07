using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Colas
{
    internal class Cola
    {
        private Nodo inicio;
        private int contador;
        private int max;

        public Cola(int maxx)
        {
            max = maxx;
            inicio = null;
        }

        private bool UnderFlow()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        private bool OverFlow()
        {
            if (contador == max)
                return true;
            else
                return false;
        }

        public void Print()
        {
            if (UnderFlow())
            {
                Console.WriteLine("La cola esta vacia.");
            }
            else
            {
                Nodo act;
                act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor}" + " " + "->" + " ");
                    act = act.Sig;
                }
            }
        }

        public int Count()
        {
            return contador;
        }

        public bool Insert(int num)
        {
            try
            {
                Nodo nuevo = new Nodo(num);
                if (UnderFlow())
                {
                    inicio = nuevo;
                    contador++;
                    return true;
                }
                else
                {
                    Nodo actual = inicio;
                    while (actual.Sig != null)
                    {
                        actual = actual.Sig;
                    }
                    actual.Sig = nuevo;
                    contador++;
                    return true;
                }
            }
            catch
            {
                Console.WriteLine("No se pudo insertar, la cola esta llena.");
                return false;
            }


            //regresa true al inseertar exitosamente
            //Regresa false si la cola esta llena y no se pudo insertar
        }

        public int Extract()
        {
            if (UnderFlow())
            {
                Console.WriteLine("La cola esta vacia.");
                return -1;
            }
            else
            {
                int valor = inicio.Valor;
                inicio = inicio.Sig;
                contador--;
                return valor;

            }
            //Regresa el valor extraido de la cola
            //Si la cola esta vacia regresa -1 por que no pudo extraer
        }



    }
}
