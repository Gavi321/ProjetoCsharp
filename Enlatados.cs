using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Enlatados
    {
        public string nome;

        public Enlatados(string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
