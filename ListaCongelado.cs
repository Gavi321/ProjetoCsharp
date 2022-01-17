using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class ListaCongelado
    {
        public List<Congelado> listaProdutos;

        public ListaCongelado()
        {
            listaProdutos = new List<Congelado>();
        }

        /*public void addProduto(Congelado congelado)
        {
            listaProdutos.Add(congelado);
        }*/

        public void lerProdutos()
        {
            foreach (Congelado item in listaProdutos)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
