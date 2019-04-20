using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class RobotFibonacci : ICalcular
    {
        public int Calcular(int num)
        {
            if (num < 46)
            {
            }

            else
            {
                num = 46;
            }
            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = 1; i < num; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
