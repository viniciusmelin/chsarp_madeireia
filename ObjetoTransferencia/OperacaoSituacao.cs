using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class OperacaoSituacao
    {
        public Operacao Operacao { get; set; }
        public Situacao Situacao { get; set; }

    }
    public class OperacaoSituacaoCollection : List<OperacaoSituacao>
    {
        public void Add(ContasReceberSitucao contasReceberSitucao)
        {
            throw new NotImplementedException();
        }
    }
}
