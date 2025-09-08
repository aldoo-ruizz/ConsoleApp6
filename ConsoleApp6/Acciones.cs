using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Acciones
    {
        public double[] numeros;
        
        public void agregar()
        {
            Console.Write("Cuantos numeros quieres ingresar? ");
            int numelementos = Convert.ToInt32(Console.ReadLine());
            numeros = new double[numelementos];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Numeros: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void mostrar()
        {
            foreach (var i in numeros)
            {
                Console.WriteLine($"Numeros: {i}");
            }
        }
        
        public double sumar()
        {
            return numeros.Sum();
        }
        public double promedio()
        {
            return numeros.Average();
        }

        public double min()
        {
            return numeros.Min();
        }
        public double max()
        {
            return numeros.Max();

        }
        public double ultimo()
        {
            return numeros.Last();
        }
        public double primero()
        {
            return numeros.First();
        }
        public void ordenar()
        {
            Array.Sort(numeros);
            foreach (var i in numeros)
            {
                Console.WriteLine(i); 
            }

        }
        public void revez()
        {
            Array.Reverse(numeros);
            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }
        }

        public int nelementos()
        {
            return numeros.Length;
        }
    }

}

