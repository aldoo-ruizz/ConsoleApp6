using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Acciones
    {
        private double[] numeros;
        
        public void Agregar()
        {
            int numelementos=Convert.ToInt32(Console.ReadLine());  
            numeros = new double[numelementos];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Numeros");
                numeros[i]=Convert.ToDouble(Console.ReadLine());

            }
        }
        public void Mostrar()
        {
            foreach (var i in numeros)
            {
                Console.WriteLine($"Numeros: {i}");
            }
        }
        public void sumar()
        {
            return ;
        }
        public void promedio()
        {

        }
    }
}
