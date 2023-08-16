namespace tabuleiro
{
    Class Tabuleiro 
    {
         public int linha { get; set; }
         public int colunas { get; set; }
         private Peca[,] pecas;

         public Tabuleiro(int linhas, int colunas)
         {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas] ;
         }
    }
}