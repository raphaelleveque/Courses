﻿using System;
using Xadrez.TabuleiroClasses;

namespace Xadrez.JogoXadrez {
    public class Cavalo : Peca {
        public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(cor, tabuleiro) {
        }

        public override string ToString() {
            return "C";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tabuleiro.GetPeca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao pos = new Posicao(0, 0);

            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 2);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(posicao.Linha - 2, posicao.Coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(posicao.Linha - 2, posicao.Coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 2);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 2);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(posicao.Linha + 2, posicao.Coluna + 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(posicao.Linha + 2, posicao.Coluna - 1);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 2);
            if (tabuleiro.PosicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}
