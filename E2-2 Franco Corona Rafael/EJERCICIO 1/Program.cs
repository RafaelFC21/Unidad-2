using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2_Franco_Corona_Rafael
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticiones, suma = 0;
            Console.Write("¿Cuantos numeros desea desplegar?: ");
            repeticiones = int.Parse(Console.ReadLine()); 
            Fibonacci serie = new Fibonacci(repeticiones, suma);
            Console.WriteLine("Fibonacci recursivo: ");
            Stopwatch tiempo1 = Stopwatch.StartNew();
            serie.recursivo(1, 0, repeticiones);
            Console.WriteLine("Tiempo: " + tiempo1.Elapsed.TotalMilliseconds + " milisegundos");
            Console.WriteLine("Fibonacci for: ");
            Stopwatch tiempo2 = Stopwatch.StartNew();
            serie.iteractivo();
            Console.WriteLine("Tiempo: " + tiempo2.Elapsed.TotalMilliseconds + " milisegundos");
            Console.WriteLine("Presione <enter> para salir...");
            Console.ReadKey();
        }
    }
}
