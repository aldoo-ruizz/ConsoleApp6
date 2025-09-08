using ConsoleApp6;
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
            agregar=1, mostrar, sumar, promedio, min, max, primero, ultimo, ordenar, revez, nelementos, salir
        }

        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();

            while (true)
            {
                switch (menu())
                {
                    case men.agregar:
                        acciones.agregar();
                        break;
                    case men.mostrar:
                        acciones.mostrar();
                        break;
                    case men.sumar:
                        Console.WriteLine($"Suma: {acciones.sumar()}");
                        break;
                    case men.promedio:
                        Console.WriteLine($"Promedio: {acciones.promedio()}");
                        break;
                    case men.min:
                        Console.WriteLine($"Mínimo: {acciones.min()}");
                        break;
                    case men.max:
                        Console.WriteLine($"Máximo: {acciones.max()}");
                        break;
                    case men.primero:
                        Console.WriteLine($"Primero: {acciones.primero()}");
                        break;
                    case men.ultimo:
                        Console.WriteLine($"Último: {acciones.ultimo()}");
                        break;
                    case men.ordenar:
                        acciones.ordenar();
                        break;
                    case men.revez:
                        acciones.revez();
                        break;
                    case men.nelementos:
                        Console.WriteLine($"Número de elementos: {acciones.nelementos()}");
                        break;
                    case men.salir:
                        return;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }
        static men menu()
        {
            Console.WriteLine("1)Agragar");
            Console.WriteLine("2)Mostrar");
            Console.WriteLine("3)Suma");
            Console.WriteLine("4)Promedio");
            Console.WriteLine("5)Minimo");
            Console.WriteLine("6)Maximo");
            Console.WriteLine("7)Primero");
            Console.WriteLine("8)Ultimo");
            Console.WriteLine("9)Ordenar");
            Console.WriteLine("10)Al revez");
            Console.WriteLine("11)Numero de elementos");
            Console.WriteLine("12)Salir");
            men opc= (men)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
