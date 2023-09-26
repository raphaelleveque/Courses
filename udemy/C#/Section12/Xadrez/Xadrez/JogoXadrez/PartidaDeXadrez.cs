using Xadrez.TabuleiroClasses;
namespace Xadrez.JogoXadrez {
    public class PartidaDeXadrez {
        public bool PartidaTerminada { get; set; }
        public Tabuleiro tabuleiro { get; private set; }
        public int turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Xeque { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;

        public PartidaDeXadrez() {
            tabuleiro = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branca;
            PartidaTerminada = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            ColocarPecas();
        }

        public Peca ExecutaMovimento(Posicao origem, Posicao destino) {
            Peca? p = tabuleiro.RemoverPeca(origem);
            if (p == null) {
                throw new TabuleiroException("Não existe nenhuma peça na posição informada! ");
            }
            Peca? pecaCapturada = tabuleiro.RemoverPeca(destino);
            tabuleiro.ColocarPeca(p, destino);
            p.IncrementarQttdMovimentos();
            if (pecaCapturada != null) {
                capturadas.Add(pecaCapturada);
            }
            return pecaCapturada;
        }

        public void RealizaJogada(Posicao origem, Posicao destino) {
            Peca pecaCapturada = ExecutaMovimento(origem, destino);
            if (EstaEmXeque(JogadorAtual)) {
                DesfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em xeque! ");
            }

            Xeque = EstaEmXeque(CorAdversaria(JogadorAtual));

            if (TesteXequeMate(CorAdversaria(JogadorAtual))) {
                PartidaTerminada = true;
            }

            turno++;
            JogadorAtual = (JogadorAtual == Cor.Branca ? Cor.Preta : Cor.Branca);
        }

        public void DesfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada) {
            Peca p = tabuleiro.RemoverPeca(destino);
            p.numeroMovimentos--;
            if (pecaCapturada != null) {
                tabuleiro.ColocarPeca(pecaCapturada, destino);
                capturadas.Remove(pecaCapturada);
            }
            tabuleiro.ColocarPeca(p, origem);
        }


        public void ValidarPosicaoDeOrigem(Posicao origem) {
            tabuleiro.ValidarPosicao(origem);
            if (tabuleiro.GetPeca(origem) == null) {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida! ");
            }
            if (JogadorAtual != tabuleiro.GetPeca(origem).cor) {
                throw new TabuleiroException("Está na vez das " + JogadorAtual + "s! ");
            }
            tabuleiro.GetPeca(origem).MovimentosPossiveis();
            if (!tabuleiro.GetPeca(origem).existemMovimentosPossiveis) {
                throw new TabuleiroException("Essa peça está bloqueada! ");
            }
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino) {
            tabuleiro.ValidarPosicao(destino);
            if (!tabuleiro.GetPeca(origem).PodeMoverPara(destino)) {
                throw new TabuleiroException("Não é possível colocar a peça na posição de destino escolhida! ");
            }
        }

        public HashSet<Peca> PecasEmJogo(Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in pecas) {
                if (x.cor == cor)
                    aux.Add(x);
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        public HashSet<Peca> pecasCapturadas(Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas) {
                if (x.cor == cor)
                    aux.Add(x);
            }
            return aux;
        }

        private Cor CorAdversaria(Cor cor) {
            return (cor == Cor.Branca ? Cor.Preta : Cor.Branca);
        }

        public bool EstaEmXeque(Cor cor) {
            Peca rei = GetRei(cor);
            if (rei == null) {
                throw new TabuleiroException("O rei da cor " + cor + " não está no tabuleiro! ");
            }
            foreach (Peca x in PecasEmJogo(CorAdversaria(cor))) {
                bool[,] mat = x.MovimentosPossiveis();
                if (mat[rei.posicao.Linha, rei.posicao.Coluna]) {
                    return true;
                }
            }
            return false;
        }

        public bool TesteXequeMate(Cor cor) {
            if (!EstaEmXeque(cor)) {
                return false;
            }

            foreach (Peca x in PecasEmJogo(cor)) {
                bool[,] mat = x.MovimentosPossiveis();
                for (int i = 0; i < tabuleiro.linhas; i++) {
                    for (int j = 0; j < tabuleiro.colunas; j++) {
                        if (mat[i, j]) {
                            Posicao origem = x.posicao;
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = ExecutaMovimento(origem, destino);
                            bool testeXeque = EstaEmXeque(cor);
                            DesfazMovimento(origem, destino, pecaCapturada);
                            if (!testeXeque) {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        private Peca GetRei(Cor cor) {
            foreach (Peca x in PecasEmJogo(cor)) {
                if (x is Rei) {
                    return x;
                }
            }
            return null;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca p) {
            tabuleiro.ColocarPeca(p, new PosicaoXadrez(coluna, linha));
            pecas.Add(p);
        }

        private void ColocarPecas() {
            colocarNovaPeca('a', 1, new Torre(Cor.Branca, tabuleiro));
            colocarNovaPeca('b', 1, new Cavalo(tabuleiro, Cor.Branca));
            colocarNovaPeca('c', 1, new Bispo(tabuleiro, Cor.Branca));
            colocarNovaPeca('d', 1, new Dama(tabuleiro, Cor.Branca));
            colocarNovaPeca('e', 1, new Rei(Cor.Branca, tabuleiro));
            colocarNovaPeca('f', 1, new Bispo(tabuleiro, Cor.Branca));
            colocarNovaPeca('g', 1, new Cavalo(tabuleiro, Cor.Branca));
            colocarNovaPeca('h', 1, new Torre(Cor.Branca, tabuleiro));
            colocarNovaPeca('a', 2, new Peao(tabuleiro, Cor.Branca));
            colocarNovaPeca('b', 2, new Peao(tabuleiro, Cor.Branca));
            colocarNovaPeca('c', 2, new Peao(tabuleiro, Cor.Branca));
            colocarNovaPeca('d', 2, new Peao(tabuleiro, Cor.Branca));
            colocarNovaPeca('e', 2, new Peao(tabuleiro, Cor.Branca));
            colocarNovaPeca('f', 2, new Peao(tabuleiro, Cor.Branca));
            colocarNovaPeca('g', 2, new Peao(tabuleiro, Cor.Branca));
            colocarNovaPeca('h', 2, new Peao(tabuleiro, Cor.Branca));

            colocarNovaPeca('a', 8, new Torre(Cor.Preta, tabuleiro));
            colocarNovaPeca('b', 8, new Cavalo(tabuleiro, Cor.Preta));
            colocarNovaPeca('c', 8, new Bispo(tabuleiro, Cor.Preta));
            colocarNovaPeca('d', 8, new Dama(tabuleiro, Cor.Preta));
            colocarNovaPeca('e', 8, new Rei(Cor.Preta, tabuleiro));
            colocarNovaPeca('f', 8, new Bispo(tabuleiro, Cor.Preta));
            colocarNovaPeca('g', 8, new Cavalo(tabuleiro, Cor.Preta));
            colocarNovaPeca('h', 8, new Torre(Cor.Preta, tabuleiro));
            colocarNovaPeca('a', 7, new Peao(tabuleiro, Cor.Preta));
            colocarNovaPeca('b', 7, new Peao(tabuleiro, Cor.Preta));
            colocarNovaPeca('c', 7, new Peao(tabuleiro, Cor.Preta));
            colocarNovaPeca('d', 7, new Peao(tabuleiro, Cor.Preta));
            colocarNovaPeca('e', 7, new Peao(tabuleiro, Cor.Preta));
            colocarNovaPeca('f', 7, new Peao(tabuleiro, Cor.Preta));
            colocarNovaPeca('g', 7, new Peao(tabuleiro, Cor.Preta));
            colocarNovaPeca('h', 7, new Peao(tabuleiro, Cor.Preta));
        }
    }
}

