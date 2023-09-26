using Xadrez.TabuleiroClasses;
namespace Xadrez.JogoXadrez {
    public class Rei : Peca {
        public Rei(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro) { }

        public override string ToString() {
            return "R";
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];
            Posicao pos = new Posicao(this.posicao.Linha, this.posicao.Coluna);
            this.existemMovimentosPossiveis = false;

            // i, j
            (int, int)[] movimentosPossiveis =
            {
                (-1, 0), (-1, -1), (-1, 1), (0, -1),
                (0, 1), (1, -1), (1, 0), (1, 1)
            };

            foreach (var (i, j) in movimentosPossiveis) {
                pos.DefinirValores(pos.Linha + i, pos.Coluna + j);
                if (tabuleiro.PosicaoValida(pos) && PodeMover(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                    existemMovimentosPossiveis = true;
                }
                pos.DefinirValores(this.posicao.Linha, this.posicao.Coluna);
            }
            return mat;
        }
    }
}

