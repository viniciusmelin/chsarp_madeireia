using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class TipoPedido
    {
        public int IDTipoPedido { get; set; }

        public string Descricao { get; set; }
    }

    public class TipoPedidoCollection : List<TipoPedido> { }
}
