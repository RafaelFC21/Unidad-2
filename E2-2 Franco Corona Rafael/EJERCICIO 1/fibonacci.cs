using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_2_Franco_Corona_Rafael
{
    class Fibonacci
    {
        int repeticiones, suma;
        public Fibonacci(int repeticiones, int suma)
        {
            this.suma = suma;
            this.repeticiones = repeticiones;
        }
        public void recursivo(double inicial, double final, int repeticiones)
        {
            double suma;
            suma = inicial + final;
            final = inicial;
            inicial = suma;
            if (repeticiones > 0)
            {
                Console.WriteLine(suma);
                recursivo(inicial, final, repeticiones - 1);
            }
        }
        public void iterativo()
        {
            int inicial = 1;
            int final = 0;
            for (int contador = 0; contador < repeticiones; contador++)
            {
                suma = inicial + final;
                final = inicial;
                inicial = suma;
                Console.WriteLine(suma);
            }
        }
    }
}
