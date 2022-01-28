using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Congelado : Produto
    {
        public Congelado(string nome, float preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public override string ToString()
        {
            return "nome: " + this.nome + " | preco: " + this.preco + "\n";
        }
    }
}
