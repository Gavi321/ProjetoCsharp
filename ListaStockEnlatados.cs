using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class ListaStockEnlatados
    {
        public List<Enlatados> stock;

        public ListaStockEnlatados()
        {
            this.stock = new List<Enlatados>();
        }
        public void lerStock()
        {
            foreach (Enlatados item in stock)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void adicionarStock(int num, Enlatados enlatados)
        {
            for (int i = 0; i < num; i++)
            {
                stock.Add(enlatados);
            }
        }
    }
}
