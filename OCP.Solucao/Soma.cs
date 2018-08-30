using System;

namespace OCP.Solucao
{
    public class Soma : Operacao
    {
        public override void ExecutarOperacao()
        {
            Console.WriteLine($"Soma: {X + Y}");
        }
    }
}
