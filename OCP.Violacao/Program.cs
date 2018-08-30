using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma soma = new Soma() { X = 2, Y = 3 };
            Multiplicacao multiplicacao = new Multiplicacao() { X = 2, Y = 3 };
            Calculo calculo = new Calculo();
            calculo.Calcular(soma);
            calculo.Calcular(multiplicacao);

            Console.ReadKey();
        }
    }
}
