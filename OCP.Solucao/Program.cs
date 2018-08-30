using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Solucao
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma soma = new Soma() { X = 4, Y = 2 };
            Multiplicacao multiplicacao = new Multiplicacao() { X = 4, Y = 2 };
            Divisao divisao = new Divisao() { X = 4, Y = 2 };
            Calculo calculo = new Calculo();
            calculo.Calcular(new List<Operacao>() { soma, multiplicacao, divisao });

            Console.ReadKey();
        }
    }
}
