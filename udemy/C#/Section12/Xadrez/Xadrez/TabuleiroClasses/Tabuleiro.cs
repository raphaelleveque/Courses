using Xadrez.JogoXadrez;
namespace Xadrez.TabuleiroClasses {
    public class Tabuleiro {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,]? _pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }

        public Peca GetPeca(int linha, int coluna) {
            return _pecas[linha, coluna];
        }

        public Peca GetPeca(Posicao pos) {
            return _pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos) {
            if (ExistePeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            _pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }

        public void ColocarPeca(Peca p, PosicaoXadrez pos) {
            if (ExistePeca(pos.ToPosicao())) {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            _pecas[pos.ToPosicao().Linha, pos.ToPosicao().Coluna] = p;
            p.posicao = pos.ToPosicao();
        }

        public Peca? RemoverPeca(Posicao pos) {
            if (!ExistePeca(pos)) {
                return null;
            }
            Peca p = _pecas[pos.Linha, pos.Coluna];
            _pecas[pos.Linha, pos.Coluna] = null;
            p.posicao = null;
            return p;
        }

        public bool ExistePeca(Posicao pos) {
            ValidarPosicao(pos);
            return GetPeca(pos) != null;
        }

        public bool PosicaoValida(Posicao pos) {
            if (pos.Linha < 0 || pos.Linha >= linhas || pos.Coluna < 0 || pos.Coluna >= colunas) {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos) {
            if (!PosicaoValida(pos)) {
                throw new TabuleiroException("Posição Inválida! ");
            }
        }
    }
}

