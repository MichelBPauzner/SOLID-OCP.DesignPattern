using System;

namespace OCP.Solucao
{
    public class Divisao : Operacao
    {
        public override void ExecutarOperacao()
        {
            Console.WriteLine($"Divisão: {X / Y}");
        }
    }
}
