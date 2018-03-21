using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Pessoa
    {
        public int IDPessoa { get; set; }
        public string Nome { get; set; }
        public decimal CpfCnpj { get; set; }
        public bool Ativo { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDPessoa.ToString();
        }
    }
    public class PessoaCollection : List<Pessoa> { }
}
