using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class ContasPagar
    {
        public int IDContasPagar { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataVencimento { get; set; }

        public DateTime? DataPagamento { get; set; }

        public DateTime DataLancamento { get; set; }

        public decimal Valor { get; set; }

        public string Observacao { get; set; }

        public OperacaoSituacao OperacaoSituacao { get; set; }

        public ContasPagarTipo ContasPagarTipo { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDContasPagar.ToString();
        }
    }

    public class ContasPagarCollection : List<ContasPagar> { }
}
