﻿using System;
using Xadrez.TabuleiroClasses;

namespace Xadrez.JogoXadrez {
    public class Dama : Peca {
        public Dama(Tabuleiro tab, Cor cor) : base(cor, tab) {
        }

        public override string ToString() {
            return "D";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tabuleiro.GetPeca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            // esquerda
            pos.DefinirValores(posicao.Linha, posicao.Coluna - 1);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.GetPeca(pos) != null && tabuleiro.GetPeca(pos).cor != cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha, pos.Coluna - 1);
            }

            // direita
            pos.DefinirValores(posicao.Linha, posicao.Coluna + 1);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.GetPeca(pos) != null && tabuleiro.GetPeca(pos).cor != cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha, pos.Coluna + 1);
            }

            // acima
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.GetPeca(pos) != null && tabuleiro.GetPeca(pos).cor != cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna);
            }

            // abaixo
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.GetPeca(pos) != null && tabuleiro.GetPeca(pos).cor != cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna);
            }

            // NO
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.GetPeca(pos) != null && tabuleiro.GetPeca(pos).cor != cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            // NE
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.GetPeca(pos) != null && tabuleiro.GetPeca(pos).cor != cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            // SE
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.GetPeca(pos) != null && tabuleiro.GetPeca(pos).cor != cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            // SO
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.GetPeca(pos) != null && tabuleiro.GetPeca(pos).cor != cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        }
    }
}