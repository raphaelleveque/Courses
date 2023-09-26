using System;
using Xadrez.TabuleiroClasses;

namespace Xadrez.JogoXadrez {
    public class Peao : Peca {
        public Peao(Tabuleiro tab, Cor cor) : base(cor, tab) {
        }

        public override string ToString() {
            return "P";
        }

        private bool existeInimigo(Posicao pos) {
            Peca p = tabuleiro.GetPeca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos) {
            return tabuleiro.GetPeca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            if (cor == Cor.Branca) {
                pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);
                if (tabuleiro.PosicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(posicao.Linha - 2, posicao.Coluna);
                Posicao p2 = new Posicao(posicao.Linha - 1, posicao.Coluna);
                if (tabuleiro.PosicaoValida(p2) && livre(p2) && tabuleiro.PosicaoValida(pos) && livre(pos) && numeroMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
                if (tabuleiro.PosicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
                if (tabuleiro.PosicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

            } else {
                pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);
                if (tabuleiro.PosicaoValida(pos) && livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(posicao.Linha + 2, posicao.Coluna);
                Posicao p2 = new Posicao(posicao.Linha + 1, posicao.Coluna);
                if (tabuleiro.PosicaoValida(p2) && livre(p2) && tabuleiro.PosicaoValida(pos) && livre(pos) && numeroMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
                if (tabuleiro.PosicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
                if (tabuleiro.PosicaoValida(pos) && existeInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }

            return mat;
        }
    }
}