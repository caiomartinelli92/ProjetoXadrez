
namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca (Tabuleiro tab, Cor cor) 
        {
            this.posicao = null;
            this.tab = tab;
            this.Cor = cor;
            this.qtdMovimentos = 0;
        }

        public void incrementaQtdMovimentos()
        {
            qtdMovimentos++;
        }
    }
}
