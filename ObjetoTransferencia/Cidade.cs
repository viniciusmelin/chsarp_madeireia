using System.Collections.Generic;

namespace SlnEstagio.ObjetoTransferencia
{

    public class Cidade
    {

        public int IDCidade { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDCidade.ToString();
        }

    }
    public class CidadeCollection : List<Cidade> { }
}
