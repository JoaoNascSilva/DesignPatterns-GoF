using System;
using System.Collections.Generic;
using System.Linq;
using Strategy.InterfaceStrategy;
using Strategy.Model;

namespace Strategy.ConcreteStrategy
{
    public class OrdenacaoDeNomePorOrdemAlfabeticaDecrescente : OrdenacaoStrategy
    {
        public override void Ordenar(IList<Cliente> listaDeCliente)
        {
            var listaOrdenada = listaDeCliente.OrderByDescending(x => x.Nome).ToList();

            Console.WriteLine("Ordenação de Nome por ordem alfabetica Decrescente...");
            base.Ordenar(listaOrdenada);
        }
    }
}