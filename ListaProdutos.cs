using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class ListaProdutos
    {
        public List<Produto> produtos;
        public ListaProdutos()
        {
            produtos = new List<Produto>();
        }

        public void imprimirProdutos()
        {
            foreach(Produto produto in produtos)
            {
                Console.Write("nome: " + produto.nome + "| preco: " + produto.preco);
            }
        }

        public void addProdutoCongelado(Congelado congelado)
        {
            produtos.Add(congelado);
        }

        public void addProdutoPrateleira(Prateleira prateleira)
        {
            produtos.Add(prateleira);
        }

        public void addProdutoEnlatado(Enlatado enlatado)
        {
            produtos.Add(enlatado);
        }
    }
}
