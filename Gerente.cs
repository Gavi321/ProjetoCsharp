using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Gerente : Funcionario
    {

        public Gerente(string nome, string username, string password)
        {
            tipoFunc cargo = tipoFunc.gerente;

            setNome(nome);
            setUsername(username);
            setPassword(password);
            setCargo(cargo);
        }
    }
}

