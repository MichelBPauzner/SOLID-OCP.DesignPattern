namespace OCP.Solucao
{
    public abstract class Operacao
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void ExecutarOperacao();
    }
}
