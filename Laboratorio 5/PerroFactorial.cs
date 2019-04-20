using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class PerroFactorial : ICalcular
    {
        public int Calcular(int num)
        {
            if (num < 13)
            {
            }
            else
            {
                num = 13;
            }
            int resultado = 1;
            for(int i = 1; i <= num; i++)
            {
                resultado = resultado * i;
            }
            return resultado;
        }
    }
}
