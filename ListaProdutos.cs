using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class ListaProdutos
    {
        public List<Produto> listaProdutos;

        public ListaProdutos()
        {
            listaProdutos = new List<Produto>();
        }

        public void imprimirProdutos()
        {
            foreach (Produto item in listaProdutos)
            {
                Console.WriteLine(item.nome);
            }
        }
    }
}
