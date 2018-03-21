using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public  class Situacao
    {
        public int IDSituacao { get; set; }
        public string Descricao { get; set; }
    }
    public class SituacaoCollection : List<Situacao>
    {
        public void Add(Operacao operacao)
        {
            throw new NotImplementedException();
        }
    }
}
