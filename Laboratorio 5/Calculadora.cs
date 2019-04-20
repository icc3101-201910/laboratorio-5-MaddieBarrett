using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    public class Calculadora
    {
        private int numero;
        public List<ICalcular> calculadoras;

        public Calculadora(int numero)
        {
            this.numero = numero;
        }

        public int GetNumero()
        {
            return numero;
        }

        public void Calcular(int num)
        {
            numero = num;
        }
    }
}
