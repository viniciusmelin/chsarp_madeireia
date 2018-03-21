using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class SegForm
    {
        public int IDForm { get; set; }
        public string Descricao { get; set; }
        public Modulo Modulo { get; set; }
        public SegMenu SegMenu { get; set; }
    }
    public class SegFormCollection : List<SegForm> { }
}
