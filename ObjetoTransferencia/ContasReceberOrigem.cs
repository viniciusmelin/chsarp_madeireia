using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class ContasReceberOrigem
    {
        public int IDContasReceberOrigem { get; set; }
        public string Descricao { get; set; }


        public string GetChavePrimaria()
        {
            return this.IDContasReceberOrigem.ToString();
        }
    }

    public class ContasReceberOrigemCollection : List<ContasReceberOrigem> { }
}
