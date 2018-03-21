using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SlnEstagio.ObjetoTransferencia
{
    public class ContasPagarTipo
    {
        public int IDContasPagarTipo { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDContasPagarTipo.ToString();
        }
    }

    public class ContasPagarTipoCollection : List<ContasPagarTipo> { }
}