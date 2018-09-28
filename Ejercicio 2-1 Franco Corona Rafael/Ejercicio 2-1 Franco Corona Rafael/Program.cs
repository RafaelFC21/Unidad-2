using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_1_Franco_Corona_Rafael
{
    class factorial
    {
        int numero;
        int resultado = 1;
        public factorial(int numero)
        {
            this.numero = numero;
        }
        public int Factorial(int numero)
        {
            if (numero == 0)
                return 1;
            else
                return numero * Factorial(numero - 1);
        }
        public int Factorial()
        {
            for (int contador = 1; contador <= numero; contador++)
            {
                resultado = resultado * (contador);
            }
            return resultado;
        }
        public void tiempo_Ejecucion()
        {
            DateTime tiempo1 = DateTime.Now;
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine("Tiempo de Ejecución con for: " + total.ToString());
        }
        public void Desplegar_resultado()
        {
            Console.WriteLine("El factorial de {0} con recursividad es: {1}", numero, Factorial(numero));
            tiempo_Ejecucion();
            Console.WriteLine("El factorial de {0} con for es: {1}", numero, resultado);
            tiempo_Ejecucion();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 6;
            factorial fact = new factorial(numero);
            fact.Desplegar_resultado();
            Console.ReadKey();
        }
    }
}
