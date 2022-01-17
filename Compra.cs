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
            foreach(KeyValuePair<string,int> itemNoCesto in itens)
            {
                if(itemNoCesto.Key == item.nome)
                {
                    int value = itemNoCesto.Value;
                    itens.Remove(itemNoCesto.Key);
                    itens.Add(item.nome, value + quant);
                }else
                {
                    itens.Add(item.nome, quant);
                }
            }
        }
        public Fatura gerarFatura(List<Produto> ListaProdutos)
        {
            var n = 0;
            var i = 0;

            foreach(Produto produto in ListaProdutos)
            {
                foreach (KeyValuePair<string,int> item in itens)
                {
                    if (item.Key == produto.nome)
                    {
                        n++;
                    }     
                }
                //Console.Write("Produto: " + produto.nome + " | Stock: " + n + "\n");
                i++;
            }

            foreach(Produto produto in ListaProdutos)
            {
                foreach(KeyValuePair<string,int> item in itens)
                {
                    if(item.Key == produto.nome)
                    {
                        total = item.Value * produto.preco;
                    }
                    else
                    {
                        total = total + produto.preco;
                    }
                }
            }
            return new Fatura(itens, total);
        }

    }
}
