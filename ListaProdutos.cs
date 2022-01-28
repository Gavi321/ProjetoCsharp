using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
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

        public void addProdutoCongelado(string nome, float preco)
        {
            Congelado congelado = new Congelado(nome, preco);
            produtos.Add(congelado);
        }

        public void addProdutoPrateleira(string nome, float preco)
        {
            Prateleira prateleira = new Prateleira(nome, preco);
            produtos.Add(prateleira);
        }

        public void addProdutoEnlatado(string nome, float preco)
        {
            Enlatado enlatado = new Enlatado(nome, preco);
            produtos.Add(enlatado);
        }
    }
}
