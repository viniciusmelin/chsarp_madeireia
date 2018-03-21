using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Telefone
    {
        public int IDTelefone { get; set; }
        public Pessoa Pessoa { get; set; }
        public decimal Numero { get; set; }
        public bool Principal { get; set; }
        public string TipoTelefone { get; set; }
        public string GetChavePrimaria()
        {
            return this.IDTelefone.ToString();
        }
    }
    public class TelefoneCollection : List<Telefone> { }
}
