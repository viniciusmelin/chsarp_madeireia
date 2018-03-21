using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class SegControle
    {
        public int IDBotao { get; set; }
        public string Descricao { get; set; }
        public SegForm SegForm { get; set; }
    }
    public class SegControleCollection : List<SegControle> { }
}
