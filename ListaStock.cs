using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class ListaStock
    {
        public List<Produto> stock;

        public ListaStock()
        {
            this.stock = new List<Produto>();
        }

        public void imprimirStock()
        {
            foreach (Produto item in stock)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void adicionarStockCongelado(Congelado congelado)
        {
            stock.Add(congelado);
        }
        public void adicionarStockPrateleira(Prateleira prateleira)
        {
            stock.Add(prateleira);
        }
        public void adicionarStockEnlatado(Enlatado enlatado)
        {
            stock.Add(enlatado);
        }
    }
}
