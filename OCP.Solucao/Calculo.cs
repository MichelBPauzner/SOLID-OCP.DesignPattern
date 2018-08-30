using System.Collections.Generic;

namespace OCP.Solucao
{
    public class Calculo
    {
        public void Calcular(List<Operacao> listaOperacoes)
        {
            foreach (var item in listaOperacoes)
            {
                item.ExecutarOperacao();
            }
        }
    }
}
