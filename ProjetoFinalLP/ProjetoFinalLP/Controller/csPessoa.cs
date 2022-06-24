using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalLP
{
    internal class csPessoa
    {
        string nomePessoa;
        DateTime dataNascPessoa;

        public void setPessoaNome(string valor)
        {
            nomePessoa = valor;
        }

        public string getPessoaNome()
        {
            return nomePessoa;
        }

        public void setPessoaDataNasc(DateTime valor)
        {
            dataNascPessoa = valor;
        }

        public DateTime getPessoaDataNasc()
        {
            return dataNascPessoa;
        }
    }
}
