using Xadrez.TabuleiroClasses;
using Xadrez.JogoXadrez;
namespace Xadrez {
    public class Tela {
        public static void ImprimirPartida(PartidaDeXadrez partida) {
            Console.Clear();
            ImprimirTabuleiro(partida.tabuleiro);
            Console.WriteLine();
            ImprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando Jogada: " + partida.JogadorAtual);
            if (partida.Xeque)
                Console.WriteLine("\nXEQUE! ");
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida) {
            Console.WriteLine("Peças capturadas: ");
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto) {
            Console.Write("[");
            foreach (Peca x in conjunto) {
                Console.Write(x + " ");
            }
            Console.WriteLine("]");
        }

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro) {
            for (int i = 0; i < tabuleiro.linhas; i++) {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.colunas; j++) {
                    Peca? p = tabuleiro.GetPeca(i, j);
                    ImprimirPeca(p);
                }
                Console.WriteLine();
            }
            Console.Write("  ");
            for (int j = 0; j < tabuleiro.colunas; j++) {
                Console.Write($"{(char)(j + 'a')} ");
            }
        }

        public static void ImprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis) {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tabuleiro.linhas; i++) {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.colunas; j++) {
                    Console.BackgroundColor = posicoesPossiveis[i, j] ? fundoAlterado : fundoOriginal;

                    Peca? p = tabuleiro.GetPeca(i, j);
                    ImprimirPeca(p);
                }
                Console.BackgroundColor = fundoOriginal;
                Console.WriteLine();
            }
            Console.Write("  ");
            for (int j = 0; j < tabuleiro.colunas; j++) {
                Console.Write($"{(char)(j + 'a')} ");
            }
        }

        public static void ImprimirPeca(Peca peca) {
            if (peca == null) {
                Console.Write("- ");
                return;
            }

            if (peca.cor == Cor.Branca) {
                Console.Write(peca + " ");
            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca + " ");
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez LerPosicao() {
            string s = Console.ReadLine();
            PosicaoXadrez p = new PosicaoXadrez(s[0], int.Parse(s[1] + ""));
            return p;
        }
    }
}

