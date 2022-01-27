using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class ListaStock
    {
        public List<Produto> stock;

        public ListaStock()
        {
            this.stock = new List<Produto>();
        }

        public void imprimirStock(List<Produto> ListaProdutos)
        {
            var n = 0;
            var aux = "";
            foreach (Produto produto in ListaProdutos)
            {
                foreach (Produto itemStock in stock)
                {
                    if (itemStock.nome == produto.nome)
                    {
                        n++;
                    }
                }
                if (produto.nome != aux)
                {
                    Console.Write("Produto: " + produto.nome + " | Stock: " + n + "\n");
                    n = 0;
                    aux = produto.nome;
                }else
                {
                    n = 0;
                }
            }
        }

        public void addStockCongelado(int quant, Congelado congelado)
        {
            for (int i = 0; i < quant; i++)
            {
                stock.Add(congelado);
            }
        }

        public void addStockPrateleira(int quant, Prateleira prateleira)
        {
            for (int i = 0; i < quant; i++)
            {
                stock.Add(prateleira);
            }
        }
        public void addStockEnlatado(int quant, Enlatado enlatado)
        {
            for (int i = 0; i < quant; i++)
            {
                stock.Add(enlatado);
            }
        }
    }
}
