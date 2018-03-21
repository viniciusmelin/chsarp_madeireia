using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
   public class OrcamentoItem
    {
        public Orcamento Orcamento { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }

        public string GetChavePrimaria()
        {
            return this.Orcamento.GetChavePrimaria();
        }

    }
    public class OrcamentoItemCollection : List<OrcamentoItem> { }
}
