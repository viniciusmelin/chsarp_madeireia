using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Produto
    {
        public int IDProduto { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Largura { get; set; }
        public decimal Profundidade { get; set; }
        public decimal Altura { get; set; }
        public decimal Cubagem { get; set; }
        public decimal QuantidadeMinina { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Preco { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDProduto.ToString();
        }
    }
    public class ProdutoCollection : List<Produto> { }
}
