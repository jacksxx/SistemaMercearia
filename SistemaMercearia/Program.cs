using System;
using System.Globalization;
using SistemaMercearia.EntidadesCompras;
namespace SistemaMercearia
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //INSTANCIANDO CLASSES NECESSARIAS
                Produto produto = new Produto();
                Compras compras = new Compras(produto);
                //iniciando sistema
                Console.WriteLine("----MERCEARIA SOBERANA----");
                Console.WriteLine();
                Console.WriteLine(" ESCOLHA A FUNÇÃO DESEJADA: ");
                Console.WriteLine(" 1 - INICIAR COMPRAS ");
                Console.WriteLine();
                Console.Write(" Digite o Número da Função Escolhida:  ");
                int função = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                //função de repetição para Lista
                while (função != 3)
                {
                    Tela.Compras(produto, compras, função);
                    função = int.Parse(Console.ReadLine());

                }
                Tela.FinalCompras(compras);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message); ;
            }

        }
    }
}