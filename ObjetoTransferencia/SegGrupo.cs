using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class SegGrupo
    {
        public int IDGrupo { get; set; }
        public string Descricao { get; set; }
    }
    public class SegGrupoCollection : List<SegGrupo> { }
}
