using System;
using System.Collections.Generic;

namespace SlnEstagio.ObjetoTransferencia
{
    
    public class Cliente
    {
        public Pessoa Pessoa { get; set; }

        public DateTime DataCadastro { get; set; }

        public decimal LimiteMinino { get; set; }

        public decimal LimiteMaximo { get; set; }
        public DateTime DataNascimento { get; set; }

        public Email Email { get; set; }

        public Endereco Endereco { get; set; }

        public Telefone Telefone {get;set;}

        public string GetChavePrimaria()
        {
            return this.Pessoa.GetChavePrimaria();
        }

    }

    public class ClienteCollection : List<Cliente> { }
}
