using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Fornecedor
    {
        public Pessoa Pessoa { get; set; }
        public string IE { get; set; }
        public DateTime DataCadastro { get; set; }

        public Endereco Endereco { get; set; }

        public Email Email { get; set; }
        public string GetChavePrimaria()
        {
            return this.Pessoa.GetChavePrimaria();
        }
    }
    public class FornecedorCollection : List<Fornecedor> { }
}
