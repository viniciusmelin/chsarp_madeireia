using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Operacao
    {
        public int IDOperacao { get; set; }
        public string Descricao { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDOperacao.ToString();
        }

    }
    public class OperacaoCollection : List<Operacao> { }
}
