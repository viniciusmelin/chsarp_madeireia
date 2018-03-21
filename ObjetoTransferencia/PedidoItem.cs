using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
   public class PedidoItem
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public string GetChavePrimaria()
        {
            return this.Pedido.GetChavePrimaria();
        }

    }
    public class PedidoItemCollection: List<PedidoItem> { }
}
