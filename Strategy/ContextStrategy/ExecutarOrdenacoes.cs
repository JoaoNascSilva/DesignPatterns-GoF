using System;
using System.Collections.Generic;
using Strategy.InterfaceStrategy;
using Strategy.Model;

namespace Strategy.ContextStrategy
{
    public class ExecutarOrdenacoes
    {
        private IList<Cliente> _listaDeCliente = new List<Cliente>()
        {
            new Cliente("Uncle Bob", new DateTime(1952, 12, 05)),
            new Cliente("Allan Turing", new DateTime(1912, 06, 23)),
            new Cliente("Tim Berners-Lee", new DateTime(1955, 07, 08)),
            new Cliente("Steve Jobs", new DateTime(1955, 02, 24)),
            new Cliente("Dennis Ritchie", new DateTime(1941, 09, 09)),
            new Cliente("Bjarne Stroustrup", new DateTime(1950, 12, 30)),
            new Cliente("Bill Gates", new DateTime(1955, 08, 28)),
            new Cliente("James Gosling", new DateTime(1955, 05, 19)),
            new Cliente("Guido van Rossum", new DateTime(1956, 01, 31)),
            new Cliente("Anders Hejlsberg", new DateTime(1960, 12, 01))
        };

        private IOrdenacaoStrategy _ordenacaoStrategy;

        public void SetarOrdenacao(IOrdenacaoStrategy ordenacaoStrategy)
        {
            this._ordenacaoStrategy = ordenacaoStrategy;
        }

        public void Ordernar()
        {
            _ordenacaoStrategy.Ordenar(_listaDeCliente);
        }
    }
}