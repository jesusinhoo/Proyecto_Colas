using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola nuevaCola = null;
            int wh = 5;

            while (wh == 5)
            {
                Console.Clear();
                Console.WriteLine("________________________");
                Console.WriteLine("|      MENU COLAS      |");
                Console.WriteLine("------------------------");
                Console.WriteLine("|1.- Establecer tamaño.|");
                Console.WriteLine("|2.- Insert.           |");
                Console.WriteLine("|3.- Extract.          |");
                Console.WriteLine("|4.- Imprimir          |");
                Console.WriteLine("|5.- Salir             |");
                Console.WriteLine("------------------------");
                Console.WriteLine("|Elige una opcion:     |");
                int opc = int.Parse(Console.ReadLine());
                Console.WriteLine("|----------------------|");

                if (opc == 1)
                {
                    Console.Clear();
                    if (nuevaCola == null)
                    {
                        Console.WriteLine("Ingresa el tamaño:");
                        int tamaño = int.Parse(Console.ReadLine());
                        nuevaCola = new Cola(tamaño);
                    }
                    else
                    {
                        Console.WriteLine("Tamaño de la cola ya establecido.");
                    }
                    Console.ReadKey();
                }
                else if (opc == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el valor a agregar: ");
                    int valor = int.Parse(Console.ReadLine());
                    nuevaCola.Insert(valor);
                    Console.ReadKey();
                }
                else if (opc == 3)
                {
                    Console.Clear();
                    Console.WriteLine(nuevaCola.Extract());
                    Console.ReadKey();
                }
                else if (opc == 4)
                {
                    Console.Clear();
                    if (nuevaCola != null)
                    {
                        Console.Clear();
                        nuevaCola.Print();
                        Console.ReadKey();
                    }
                    else
                        Console.WriteLine("La Cola esta vacia.");
                    Console.ReadKey();

                }
                else if (opc == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Saliendo...");
                    Console.WriteLine("Presiona enter...");
                    wh = 0;
                    Console.ReadKey();
                }

            }
        }

    }
}
