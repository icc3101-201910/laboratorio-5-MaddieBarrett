using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cubo cubo = new Cubo();
            PerroFactorial perrofactorial = new PerroFactorial();
            RobotFibonacci robotfibonacci = new RobotFibonacci();
            PersonaQueSuma5 personaquesuma5 = new PersonaQueSuma5();
            Cuadrado cuadrado = new Cuadrado();
            Random random = new Random();

            List<ICalcular> calculadoras = new List<ICalcular>();
            calculadoras.Add(cubo);
            calculadoras.Add(perrofactorial);
            calculadoras.Add(robotfibonacci);
            calculadoras.Add(personaquesuma5);
            calculadoras.Add(cuadrado);
            Calculadora calculadora = new Calculadora(2);

            Console.WriteLine("Ingresa el numero de calculos a realizar: ");
            int calculosarealizar = int.Parse(Console.ReadLine());
            for (int i=1; i <= calculosarealizar; i++)
            {
                ICalcular calculadorautilizar = calculadoras[random.Next(0, 5)];
                Console.WriteLine("");
                Console.WriteLine("---El numero para calcular es : {0} y se usara la calculadora : {1} ----", calculadora.GetNumero(), calculadorautilizar);
                Console.WriteLine("EL RESULTADO ES:");
                int num = calculadorautilizar.Calcular(calculadora.GetNumero());
                calculadora.Calcular(num);
                Console.WriteLine(calculadora.GetNumero());

            }

            Console.WriteLine("------------PARTE 4-------------");
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("[1] Cubo");
            Console.WriteLine("[2] Perro Factorial");
            Console.WriteLine("[3] Robot Fibonacci");
            Console.WriteLine("[4] Persona que suma 5");
            Console.WriteLine("[5] Cuadrado");
            Console.WriteLine("[6] Exit");


            int seleccion = int.Parse(Console.ReadLine());

            calculadora.Calcular(2);
            while (seleccion != 6)
            {
                Console.WriteLine("");
                Console.WriteLine("-----El numero a calcular es {0}-----", calculadora.GetNumero());
                Console.WriteLine("EL RESULTADO ES:");
                int numero = calculadoras[seleccion - 1].Calcular(calculadora.GetNumero());
                calculadora.Calcular(numero);
                Console.WriteLine(calculadora.GetNumero());

                Console.WriteLine("CALCULADORA");
                Console.WriteLine("[1] Cubo");
                Console.WriteLine("[2] Perro Factorial");
                Console.WriteLine("[3] Robot Fibonacci");
                Console.WriteLine("[4] Persona que suma 5");
                Console.WriteLine("[5] Cuadrado");
                Console.WriteLine("[6] Exit");
                Console.WriteLine("");

                seleccion = int.Parse(Console.ReadLine());
            }
        }
    }
}
