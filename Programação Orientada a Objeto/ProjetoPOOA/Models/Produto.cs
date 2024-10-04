namespace ProjetoPOOA.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public  string Descricao { get; set; }
        public string CodigoBarras { get; set; }
        public char Unidade { get; set; }
        public decimal PrecoVenda { get; set; }
        public int EstoqueAtual { get; set; }
    }
}