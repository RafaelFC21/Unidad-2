using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2__Franco_Corona_Rafael
{
    class Recursivo
    {
        int sucesion;
        public Recursivo(int sucesion)
        {
            this.sucesion = sucesion;
        }
        public int Minimo(int sucesion, int[] Sucesion, int Min)
        {
            if (sucesion != Sucesion.Length)
            {
                if (Sucesion[sucesion] < Min)
                    Min = Minimo(sucesion + 1, Sucesion, Sucesion[sucesion]);
                else
                    Min = Minimo(sucesion + 1, Sucesion, Min);
            }
            return Min;
        }
        public int Maximo(int sucesion, int[] Sucesion, int Max)
        {
            if (sucesion != Sucesion.Length)
            {
                if (Sucesion[sucesion] > Max)
                    Max = Maximo(sucesion + 1, Sucesion, Sucesion[sucesion]);
                else
                    Max = Maximo(sucesion + 1, Sucesion, Max);
            }
            return Max;
        }
        public void invertir(int veces, int[] Sucesion)
        {
            double numero = 0;
            if (veces > 0)
            {
                numero = Sucesion[veces - 1];
                Console.Write(numero + " ");
                invertir(veces - 1, Sucesion);
            }
        }
    }
}
