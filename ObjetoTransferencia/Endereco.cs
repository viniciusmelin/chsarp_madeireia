using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Endereco
    {
        public int IDEndereco { get; set; }
        public Pessoa Pessoa { get; set; }
        //public Cidade Cidade { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public decimal Cep { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDEndereco.ToString();
        }

    }

    public class EnderecoCollection : List<Endereco> { }
}
