using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class ContasReceberSitucao
    {
        public int IDContasReceberSituacao { get; set; }
        public string Descricao { get; set; }
    }

    public class ContasReceberSituacaoCollection : List<ContasReceberSitucao> { }
}
