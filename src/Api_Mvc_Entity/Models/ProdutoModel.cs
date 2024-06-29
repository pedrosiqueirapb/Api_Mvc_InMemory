namespace Api_Mvc_Entity.Models
{
    public class ProdutoModel
    {
        public int Id { get; init; }
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public int AvaliacaoProduto { get; set; }
        public string CategoriaProduto { get; set; }
        /*
        public ProdutoModel(string NomeProduto, double PrecoProduto, string DescricaoProduto, int QuantidadeProduto, int AvaliacaoProduto, string CategoriaProduto)
        {
            this.NomeProduto = NomeProduto;
            this.PrecoProduto = PrecoProduto;
            this.DescricaoProduto = DescricaoProduto;
            this.QuantidadeProduto = QuantidadeProduto;
            this.AvaliacaoProduto = AvaliacaoProduto;
            this.CategoriaProduto = CategoriaProduto;
        }
        */
    }
}
