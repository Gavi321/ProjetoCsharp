using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Funcionario
    {
        public string nome;
        public string username;
        public string password;
        public tipoFunc cargo;
        
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

        public Funcionario addFunc(string nome, string username, string password, tipoFunc tipo)
        {
            if(tipo == tipoFunc.gerente)
            {
                return new Gerente(nome, username, password);
            }else if (tipo == tipoFunc.repositor)
            {
                return new Repositor(nome, username, password);
            }else if (tipo == tipoFunc.caixa)
            {
                return new Caixa(nome, username, password);
            }
            return null;
        }

        /*public void imprimirFaturaCheck()
        {
            if(this.getCargo() == tipoFunc.caixa)
            {
                imprimirFatura();
            }
            else
            {
                Console.WriteLine("Nao e caixa");
            }
        }*/
    }
}
