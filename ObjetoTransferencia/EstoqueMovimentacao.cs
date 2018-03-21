using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class EstoqueMovimentacao
    {
        public int IDMovimentacao { get; set; }
        public DateTime Data { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade  { get; set; }

        public string Operacao { get; set; }

        public string GetChavePrimaria()
        {
            return IDMovimentacao.ToString();
        }
    }
    public class EstoqueMovimentacaoCollection : List<EstoqueMovimentacao> { }
}
