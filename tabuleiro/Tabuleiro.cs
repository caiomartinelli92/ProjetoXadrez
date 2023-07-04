namespace tabuleiro
{
    class Tabuleiro
    {
        public int linha {  get; set; }
        public int colunas { get; set; }
        public Peca[,] pecas;

        public Tabuleiro (int linhas, int colunas)
        {
            this.linha = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
