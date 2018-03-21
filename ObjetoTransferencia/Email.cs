using System.Collections.Generic;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Email
    {
        public int IDEmail { get; set; }

        public Pessoa Pessoa { get; set; }

        public string Descricao { get; set; }
        public bool Principal { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDEmail.ToString();
        }
    }
    public class EmailCollection: List<Email> { }
}
