using Xadrez.TabuleiroClasses;
using Xadrez.JogoXadrez;
namespace Xadrez;

class Program {
    static void Main(string[] args) {
        PartidaDeXadrez partida = new PartidaDeXadrez();

        while (!partida.PartidaTerminada) {
            try {
                Tela.ImprimirPartida(partida);

                Console.Write("\nOrigem: ");
                Posicao origem = Tela.LerPosicao().ToPosicao();
                partida.ValidarPosicaoDeOrigem(origem);

                bool[,] posicoesPossiveis = partida.tabuleiro.GetPeca(origem).MovimentosPossiveis();

                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tabuleiro, posicoesPossiveis);
                Console.WriteLine();
                Console.WriteLine("\nTurno: " + partida.turno);
                Console.WriteLine("Aguardando Jogada: " + partida.JogadorAtual);

                Console.Write("\nDestino: ");
                Posicao destino = Tela.LerPosicao().ToPosicao();
                partida.ValidarPosicaoDeDestino(origem, destino);
                partida.RealizaJogada(origem, destino);
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

    }
}

