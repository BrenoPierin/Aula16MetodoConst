using System;

namespace Aula16MetodoConst
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            
            Produto produto2 = new Produto(666);
            System.Console.WriteLine($" o codigo do produto é {produto2.codigo}");

            System.Console.WriteLine();
            
            Produto produto3 = new Produto("Air force", 666, 13);
            System.Console.WriteLine($"O produto {produto3.nome} com o codigo {produto3.codigo} tem {produto3.estoque} pares no estoque");


        }
    }
}
