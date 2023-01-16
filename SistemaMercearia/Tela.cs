using SistemaMercearia.EntidadesCompras;
using System.Globalization;

namespace SistemaMercearia
{
    class Tela
    {
        public static void Compras(Produto produto, Compras compras, int função)
        {            
            Console.Clear();
            //Função para iniciar compras e adicionar produtos
            if (função == 1)
            {
                Console.Write(" Digite o Nome do Produto: ");
                string nome = Console.ReadLine();
                Console.Write(" Digite o Valor do Produto: R$ ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write(" Digite a Quantidade do Produto: ");
                int quantidade = int.Parse(Console.ReadLine());
                produto = new Produto(nome, valor, quantidade);
                compras.addlista(produto);
                Console.WriteLine();
            }
            //função para remover produtos
            else if (função == 2)
            {
                foreach (Produto prod in compras.ListadeCompras)
                {
                    Console.WriteLine("|- " + prod.Nome + " -|");
                }
                Console.WriteLine();
                Console.Write(" Digite o Nome do Produto para Remover: ");
                string nome = Console.ReadLine();
                int index = compras.ListadeCompras.FindLastIndex(c => c.Nome == $"{nome}");
                if (index != -1)
                {
                    compras.removeLista(compras.ListadeCompras[index]);
                }

                Console.WriteLine();
            }

            Console.Clear();
            //VISUALIZAÇÃO DOS PRODUTOS QUE ESTÃO NA LISTA
            foreach (Produto prod in compras.ListadeCompras)
            {
                Console.WriteLine("| " + prod.Nome + " |R$ " + prod.Preço.ToString("F2", CultureInfo.InvariantCulture) + " |Qtd "
                    + prod.Quantidade + " = R$ " + prod.valorDoProduto().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            Console.WriteLine("Valor Atual: R$ " + compras.valorTotal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write(" 1 - ADICIONAR PRODUTO |");
            Console.Write(" 2 - REMOVER PRODUTO |");
            Console.WriteLine(" 3 - FINALIZAR COMPRA |");
            Console.WriteLine();
            Console.Write(" Digite o Número da Função Escolhida:  ");
            

        }

        public static void FinalCompras(Compras compras)
        {
            Console.Clear();
            //FINALIZAÇÃO DA COMPRA
            Console.Write(" VALOR TOTAL DAS COMPRAS: R$ ");
            double valorFinal = compras.valorTotal();
            Console.WriteLine(valorFinal.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write(" Dinheiro Recibido: R$ ");
            double dinheiroRecebido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(" Troco: R$ " + compras.troco(valorFinal, dinheiroRecebido).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
