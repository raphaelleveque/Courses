using System;
namespace Secao4Problema2 {
    public class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
            Nome = "";
            Preco = 0;
            Quantidade = 0;
        }
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            if (Quantidade > quantidade) {
                Quantidade -= quantidade;
            }
        }

        public override string ToString() {
            return $"{Nome}, ${Preco}, Quantidade: {Quantidade}";
        }
    }
}

