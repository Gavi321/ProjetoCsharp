using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Compra
    {
        public Dictionary<string,int> itens;
        public float total;

        public Compra(){
            itens = new Dictionary<string, int>();
        }

        public void addItemCesto(Produto item, int quant)
        {
            if (itens.ContainsKey(item.nome))
            {
                itens[item.nome] += quant;
            }
            else
            {
                itens.Add(item.nome, quant);
            }
        }
        public Fatura gerarFatura(List<Produto> ListaProdutos)
        {
            foreach(Produto produto in ListaProdutos)
            {
                foreach(KeyValuePair<string,int> item in itens)
                {
                    if(item.Key == produto.nome)
                    {
                        total += item.Value * produto.preco;
                    }
                }
            }
            return new Fatura(itens, total);
        }

    }
}
