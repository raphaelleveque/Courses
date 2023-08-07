using System;
using Secao4Problema2;

internal class Program {
    private static void Main(string[] args) {
        DateTime d = new DateTime();
        d = DateTime.Now;
        string s = d.ToLongDateString();
        Console.WriteLine(s);
        //Produto p1 = new Produto();
        //Console.WriteLine("Digite o nome do produto: ");
        //p1.Nome = Console.ReadLine();
        //Console.WriteLine("Digite o preço do produto: ");
        //p1.Preco = int.Parse(Console.ReadLine());
        //Console.WriteLine("Digite a quantidade do produto: ");
        //p1.Quantidade = int.Parse(Console.ReadLine());

        //Console.WriteLine($"Valor total em estoque: {p1.ValorTotalEmEstoque()}");
        //Console.WriteLine(p1);
    }
}