using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS
{
    internal class Program
    {
        public enum men
        { 
            agregar, mostrar=1, sumar, promedio, min, max, primero, ultimo, ordenar, revez, nelementos, salir
        }
        static void Main(string[] args)
        {
            while (true)
            {
                switch (menu())
                {
                    case men.agregar:

                        break;
                    case men.mostrar:
                        break;
                    case men.sumar:
                        break;
                    case men.promedio:
                        break;
                    case men.min:
                        break;
                    case men.max:
                        break;
                    case men.primero:
                        break;
                    case men.ultimo:
                        break;
                    case men.ordenar:
                        break;
                    case men.revez:
                        break;
                    case men.nelementos:
                        break;
                    case men.salir:
                        break;
                    default:
                        break;
                }
            }
        }
        static men menu()
        {
            Console.WriteLine("1)Agragar");
            Console.WriteLine("2)Mostrar");
            Console.WriteLine("3)suma");
            Console.WriteLine("4)promedio");
            Console.WriteLine("5)Minimo");
            Console.WriteLine("6)Maximo");
            Console.WriteLine("7)Primero");
            Console.WriteLine("8)ultimo");
            Console.WriteLine("9)ordenar");
            Console.WriteLine("10)al revez");
            Console.WriteLine("11)Numero de elementos");
            Console.WriteLine("12)Salir");
            men opc= (men)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
