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

        }

        public int Count()
        {

        }

        public bool Insert(int num)
        {
            //regresa true al inseertar exitosamente
            //Regresa false si la cola esta llena y no se pudo insertar
        }

        public int Extract()
        {
            //Regresa el valor extraido de la cola
            //Si la cola esta vacia regresa -1 por que no pudo extraer
        }



    }
}
