using Projeto_Xadrez;
using System.Linq.Expressions;
using tabuleiro;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirPartida(partida);

        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        partida.validarPosicaoDeOrigem(origem);

        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab,posicoesPossiveis);

        Console.WriteLine();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
        partida.validarPosicaoDestino(origem,destino);

        partida.executaMovimento(origem, destino);
    }
    Console.Clear();
    Tela.imprimirPartida(partida);
}catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}