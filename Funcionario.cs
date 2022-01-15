using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Funcionario
    {
        private string nome;
        private string username;
        private string password;
        private tipoFunc cargo;
        
        public enum tipoFunc{gerente,repositor,caixa,};
               
        public Funcionario()
        {
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getUsername()
        {
            return username;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return password;
        }

        public void setCargo(tipoFunc cargo)
        {
            this.cargo = cargo;
        }

        public tipoFunc getCargo()
        {
            return cargo;
        }

        public void addFunc(string nome, string username, string password, tipoFunc tipo)
        {
            if(tipo == tipoFunc.gerente)
            {
                Gerente(nome,username,password);
            }else if(tipo == tipoFunc.repositor)
            {
                Repositor(nome,username,password);
            }else if(tipo == tipoFunc.caixa)
            {
                Caixa(nome, username, password);
            }
        }
    }
}
