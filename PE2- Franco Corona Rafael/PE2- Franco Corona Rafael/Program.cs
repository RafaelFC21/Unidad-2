using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PE2__Franco_Corona_Rafael
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese un numero para hacerle su sucesion: ");
                int sucesion = Int32.Parse(Console.ReadLine());
                Console.Write("Cuantos numeros de la sucesión desea: ");
                int veces = Int32.Parse(Console.ReadLine());
                int[] Sucesion = new int[veces];
                for (int contador = 0; contador < veces; contador++)
                {
                    Sucesion[contador] = sucesion * (contador + 1);
                    Console.WriteLine(Sucesion[contador]);
                }
                Recursivo recursivo = new Recursivo(sucesion);
                Console.WriteLine("El minimo es: " + recursivo.Minimo(0, Sucesion, Sucesion[0]));
                Console.WriteLine("El maximo es: " + recursivo.Maximo(0, Sucesion, Sucesion[0]));
                Console.WriteLine("Los números invertidos son: ");
                recursivo.invertir(veces, Sucesion);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
