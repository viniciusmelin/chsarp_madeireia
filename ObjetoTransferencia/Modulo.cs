using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Modulo
    {
        public int IDModulo { get; set; }
        public string Descricao { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDModulo.ToString();
        }

    }
    public class ModuloCollection : List<Modulo> { }
}
