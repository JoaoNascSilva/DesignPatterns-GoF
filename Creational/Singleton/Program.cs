using System;
using Singleton.Connection;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionDataBase1 = ConnectionDataBase.Instance();
            var connectionDataBase2 = ConnectionDataBase.Instance();

            if (connectionDataBase1 == connectionDataBase2)
                Console.WriteLine($"\n(HashCode)Conexão 1: {connectionDataBase1.GetHashCode()} \n(HashCode)Conexão 2: {connectionDataBase2.GetHashCode()}\nConexão 1 e 2 são a mesma..");
        }
    }
}
