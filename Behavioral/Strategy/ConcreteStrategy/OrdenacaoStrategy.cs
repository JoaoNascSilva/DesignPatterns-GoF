using System;
using System.Collections.Generic;
using Strategy.InterfaceStrategy;
using Strategy.Model;

namespace Strategy.ConcreteStrategy
{
    public abstract class OrdenacaoStrategy : IOrdenacaoStrategy
    {
        public virtual void Ordenar(IList<Cliente> listaDeCliente)
        {
            foreach (var pessoa in listaDeCliente)
            {
                Console.WriteLine($"Pessoa: {pessoa.Id} - {pessoa.Nome} {pessoa.DataDeNascimento}");
            }
            Console.WriteLine();
        }
    }
}