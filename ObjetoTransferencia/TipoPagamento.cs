using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class TipoPagamento
    {
        public int IDTipoPagamento { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDTipoPagamento.ToString();
        }

    }
    public class TipoPagamentoCollection : List<TipoPagamento> { }
}
