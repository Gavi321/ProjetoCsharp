using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class ListaPrateleira
    {
        public List<Prateleira> listaProdutos;

        public ListaPrateleira()
        {
            listaProdutos = new List<Prateleira>();
        }

        public void lerProdutos()
        {
            foreach (Prateleira item in listaProdutos)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}