using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class ListaEnlatados
    {
        public List<Enlatados> listaProdutos;

        public ListaEnlatados()
        {
            listaProdutos = new List<Enlatados>();
        }

        public void lerProdutos()
        {
            foreach (Enlatados item in listaProdutos)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
