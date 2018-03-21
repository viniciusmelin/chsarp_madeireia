using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class SegFormControleAcesso
    {
        public Modulo Modulo { get; set; }
        public SegForm SegForm { get; set; }
        public SegControle SegControle { get; set; }
        public SegGrupo SegGrupo { get; set; }
        public bool Ativo { get; set; }

    }
    public class SegFormControleAcessoCollection : List<SegFormControleAcesso> { }
}
