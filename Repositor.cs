using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Repositor : Funcionario
    {
        private string nome;
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public Repositor(string nome, string username, string password)
        {
            tipoFunc cargo = tipoFunc.repositor;

            setNome(nome);
            setUsername(username);
            setPassword(password);
            setCargo(cargo);
        }
    }

}
