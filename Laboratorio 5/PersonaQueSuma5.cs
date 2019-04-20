using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class PersonaQueSuma5 : ICalcular
    {
        public int Calcular(int num)
        {
            return num + 5;
        }
    }
}
