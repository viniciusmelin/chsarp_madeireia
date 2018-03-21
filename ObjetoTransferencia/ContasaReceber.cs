using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
   public class ContasaReceber
    {
        public int IDContasaReceber { get; set; }
        public DateTime? DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPagar { get; set; }
        public DateTime DataLancamento { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Usuario Usuario { get; set; }
        public Pedido Pedido { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

        public ContasReceberSitucao ContasReceberSituacao { get; set; }
        public ContasReceberOrigem ContasReceberOrigem { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDContasaReceber.ToString();
        }

    }

    public class ContasReceberCollection : List<ContasaReceber> { }
}
