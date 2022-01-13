using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Congelado
    {
        public string nome;
        
        public Congelado(string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
