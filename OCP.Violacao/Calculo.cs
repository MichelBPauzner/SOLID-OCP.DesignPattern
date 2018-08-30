using System;

namespace OCP.Violacao
{
    public class Calculo
    {
        public void Calcular(Operacao operacao)
        {
            if (operacao is Soma)
                Console.WriteLine($"Soma: {operacao.X + operacao.Y}");
            if(operacao is Multiplicacao)
                Console.WriteLine($"Multiplicação: {operacao.X * operacao.Y}");
        }
    }
}
