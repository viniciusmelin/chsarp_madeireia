using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class SegMenu
    {
        public int IDMenu { get; set; }
        public string Descricao { get; set; }

        public Modulo Modulo { get; set; }

    }
    public class SegMenuCollection : List<SegMenu> { }
}
