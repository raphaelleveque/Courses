using System;
namespace Xadrez.TabuleiroClasses {
    public abstract class Peca {
        public Posicao? posicao { get; set; }
        public Cor cor { get; protected set; }
        public int numeroMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; protected set; }
        public bool existemMovimentosPossiveis { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro) {
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            posicao = null;
            numeroMovimentos = 0;
        }

        public void IncrementarQttdMovimentos() {
            numeroMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();

        protected virtual bool PodeMover(Posicao pos) {
            Peca p = tabuleiro.GetPeca(pos);
            return p == null || p.cor != this.cor;
        }

        public bool PodeMoverPara(Posicao destino) {
            return MovimentosPossiveis()[destino.Linha, destino.Coluna];
        }
    }
}

