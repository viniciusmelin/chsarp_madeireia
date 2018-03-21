using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Vendedor
    {
        public Pessoa Pessoa { get; set; }
        public DateTime DataCadastro { get; set; }

        public Email Email { get; set; }

        public string GetChavePrimaria()
        {
            return this.Pessoa.IDPessoa.ToString();
        }
    }

    public class VendedorCollection : List<Vendedor> { }
}
