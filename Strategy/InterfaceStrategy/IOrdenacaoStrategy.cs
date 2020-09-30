using System.Collections.Generic;
using Strategy.Model;

namespace Strategy.InterfaceStrategy
{
    public interface IOrdenacaoStrategy
    {
        void Ordenar(IList<Cliente> listaDeCliente);
    }
}