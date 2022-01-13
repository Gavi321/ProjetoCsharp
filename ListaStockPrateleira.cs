using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class ListaStockPrateleira
    {
        public List<Prateleira> stock;

        public ListaStockPrateleira()
        {
            this.stock = new List<Prateleira>();
        }
        public void lerStock()
        {
            foreach (Prateleira item in stock)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void adicionarStock(int num, Prateleira prateleira)
        {
            for (int i = 0; i < num; i++)
            {
                stock.Add(prateleira);
            }
        }
    }
}
