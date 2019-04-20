using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class Cuadrado: ICalcular
    {
        public int Calcular(int num)
        {
            return num * num;
        }
    }
}
