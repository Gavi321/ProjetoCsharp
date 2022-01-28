using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    class Caixa : Funcionario
    {
        public Caixa(string nome, string username, string password)
        {
            tipoFunc cargo = tipoFunc.caixa;

            setNome(nome);
            setUsername(username);
            setPassword(password);
            setCargo(cargo);
        }
    }
}
