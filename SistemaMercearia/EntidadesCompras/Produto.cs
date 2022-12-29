
namespace SistemaMercearia.EntidadesCompras
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preço { get; set; }
        public int Quantidade { get; set; }
        
        public Produto()
        {

        }
        public Produto(string nome, double preço, int quantidade)
        {
            Nome = nome;
            Preço = preço;
            Quantidade = quantidade;
        }

        public double valorDoProduto()
        {
            return (Preço * Quantidade);            
        }        
    }
}
