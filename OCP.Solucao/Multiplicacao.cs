using System;

namespace OCP.Solucao
{
    public class Multiplicacao: Operacao
    {
        public override void ExecutarOperacao()
        {
            Console.WriteLine($"Multiplicação: {X * Y}");
        }
    }
}
