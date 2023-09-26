using Xadrez.TabuleiroClasses;
namespace Xadrez.JogoXadrez {
    public class Torre : Peca {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro) { }

        public override string ToString() {
            return "T";
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];
            Posicao pos = new Posicao(this.posicao.Linha, this.posicao.Coluna);
            this.existemMovimentosPossiveis = false;

            (int, int)[] movimentosPossiveis = { (1, 0), (-1, 0), (0, 1), (0, -1) };
            for (int i = 0; i < movimentosPossiveis.Length; i++) {
                pos.DefinirValores(pos.Linha + movimentosPossiveis[i].Item1, pos.Coluna + movimentosPossiveis[i].Item2);
                while (tabuleiro.PosicaoValida(pos) && PodeMover(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                    this.existemMovimentosPossiveis = true;

                    if (tabuleiro.GetPeca(pos) != null && tabuleiro.GetPeca(pos).cor != this.cor) {
                        break;
                    }
                    pos.Linha += movimentosPossiveis[i].Item1;
                    pos.Coluna += movimentosPossiveis[i].Item2;
                }
                pos.DefinirValores(this.posicao.Linha, this.posicao.Coluna);
            }
            return mat;
        }
    }
}

