//O QUE FALTA MAIS ? RETIRAR O COMENTÁRIO APOS FAZER AS ALTERAÇÕES
namespace VendasAPI.Domínio.Entidades
{
    public class Item
    {
        private double custo;
        private double margem;
        private double venda;

        public Item(string descricao, string marca, double custo, double margem, double venda)//Criei esse construtor
        {
            Descricao = descricao;
            Marca = marca;
            this.custo = custo;
            this.margem = margem;
            this.venda = venda;
        }

        public int ItemID { get; set; }
        public int CodigoEstoque { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double ValorCusto { get; set; }
        public double ValorVenda { get; set; }
        public double MargemMaxima { get; set; }

    }
}
