using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class SegGrupoUsuario
    {
        public SegGrupo SegGrupo { get; set; }
        public Usuario Usuario { get; set; }

    }
    public class SegUsuarioCollection : List<SegGrupoUsuario> { }
}
