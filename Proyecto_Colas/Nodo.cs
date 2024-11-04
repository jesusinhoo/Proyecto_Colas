using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Colas
{
    internal class Nodo
    {
        private int valor;
        private Nodo sig;

        public Nodo(int valorr)
        {
            valor = valorr;
            sig = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal Nodo Sig { get => sig; set => sig = value; }
    }
}
