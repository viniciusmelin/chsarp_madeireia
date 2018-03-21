using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public  class Orcamento
    {
        public int IDOrcamento { get; set; }

        public TipoPagamento TipoPagamento { get; set; }

        public OperacaoSituacao OperacaoSituacao { get; set; }

        public string Observacao { get; set; }

        public DateTime DataOrcamento { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDOrcamento.ToString();
        }
    }
    public class OrcamentoCollection : List<Orcamento> { }
}
