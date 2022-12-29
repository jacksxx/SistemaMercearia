using System.Collections.Generic;
using System.Globalization;
namespace SistemaMercearia.EntidadesCompras
{
    class Compras 
    {     
        public Produto Produto { get; set; }
        public double ValorFinal { get; set; } 
        public List<Produto> ListadeCompras { get; private set; } = new List<Produto>();

        public Compras()
        {

        }
        public Compras(Produto produto)
        {
            Produto = produto;
            
        }

        public void addlista(Produto produtos)
        {
            ListadeCompras.Add(produtos);
        }
        public void removeLista(Produto produtos)
        {
            ListadeCompras.Remove(produtos);
        }

        public double valorTotal()
        {
            double sum = ValorFinal;
            foreach(Produto produtos in ListadeCompras)
            {
                sum += produtos.valorDoProduto();
            }
            return sum;
        }
        
        public double troco(double valorfinal, double dinheiropago)
        {
            if (dinheiropago == valorfinal)
            {
                return 0.00;
            }
            else if (dinheiropago > valorfinal)
            {
                return dinheiropago - valorfinal;
            }
            else
            {
                return double.Parse("ESTÁ FALTANDO DINHEIRO: R$ " + ((dinheiropago - valorfinal)* - 1));
            }
        }
    }
}
