using System;
using System.Threading;

namespace MeuPrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Aguarde...");
            Thread.Sleep(2000);
            Console.WriteLine("Olá: " + nome);
        }
    }
}
