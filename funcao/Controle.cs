namespace funcao
{
    internal class Venda
    {
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }

        public Venda(string produto, int quantidade, double valorUnitario)
        {
            Produto = produto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public double CalcularTotal()
        {
            return Quantidade * ValorUnitario;
        }
    }
}
