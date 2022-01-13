using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Prateleira : Produto
    {

        public Prateleira(string nome, float preco)
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
