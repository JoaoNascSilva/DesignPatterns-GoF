using System;
namespace Strategy.Model
{
    public class Cliente
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }

        public Cliente(string nome, DateTime dataDeNascimento)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.DataDeNascimento = dataDeNascimento;
        }
    }
}