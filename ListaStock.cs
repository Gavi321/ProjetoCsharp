using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class ListaStock
    {
        public List<Congelado> stock;

        public ListaStock()
        {
            this.stock = new List<Congelado>();
        }
        public void lerStock()
        {
            foreach (Congelado item in stock)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void adicionarStock(int num, Congelado congelado)
        {
            for (int i = 0; i < num; i++)
            {
                stock.Add(congelado);
            }
        }



    }
}
