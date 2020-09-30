using Strategy.ConcreteStrategy;
using Strategy.ContextStrategy;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutarOrdenacoes executarOrdenacoes = new ExecutarOrdenacoes();

            executarOrdenacoes.SetarOrdenacao(new OrdenacaoDeNomePorOrdemAlfabeticaCrescente());
            executarOrdenacoes.Ordernar();

            executarOrdenacoes.SetarOrdenacao(new OrdenacaoDeNomePorOrdemAlfabeticaDecrescente());
            executarOrdenacoes.Ordernar();

            executarOrdenacoes.SetarOrdenacao(new OrdenacaoDeDataPorOrdemCrescente());
            executarOrdenacoes.Ordernar();
        }
    }
}
