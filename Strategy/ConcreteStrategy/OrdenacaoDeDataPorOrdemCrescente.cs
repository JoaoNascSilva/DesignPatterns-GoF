using System;
using System.Collections.Generic;
using System.Linq;
using Strategy.InterfaceStrategy;
using Strategy.Model;

namespace Strategy.ConcreteStrategy
{
    public class OrdenacaoDeDataPorOrdemCrescente : OrdenacaoStrategy
    {
        public override void Ordenar(IList<Cliente> listaDeCliente)
        {
            var ordernacaoPorDataCrescente = listaDeCliente.OrderBy(x => x.DataDeNascimento).ToList();

            Console.WriteLine("Ordenação de Data por ordem Crescente...");
            base.Ordenar(ordernacaoPorDataCrescente);
        }
    }
}