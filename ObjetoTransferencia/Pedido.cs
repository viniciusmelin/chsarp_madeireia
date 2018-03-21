using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Pedido
    {
        public int IDPedido { get; set; }
        public Pessoa Pessoa { get; set; }

        public OperacaoSituacao OpercaoSituacao { get; set; }
        //public Orcamento Orcamento { get; set; }
        public DateTime DataPedido { get; set; }
        //public TipoPagamento TipoPagamento { get; set; }

        public Vendedor Vendedor { get; set; }

        public Cliente Cliente { get; set; }

        public TipoPedido TipoPedido { get; set; }

        public decimal ValorTotal { get; set; }

        public string Observacao { get; set; }


        public string GetChavePrimaria()
        {
            return this.IDPedido.ToString();
        }
    }
    public class PedidoCollection : List<Pedido> { }
}
