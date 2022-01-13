using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Prateleira
    {
        public string nome;

        public Prateleira(string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}