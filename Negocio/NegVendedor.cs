using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using SlnEstagio.AcessoDados;
using SlnEstagio.ObjetoTransferencia;

namespace SlnEstagio.Negocio
{
    public class NegVendedor
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();
        public string Inserir(Vendedor vendedor)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDPessoa", vendedor.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", vendedor.Pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", vendedor.Pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", vendedor.Pessoa.Ativo);
                AcessoDados.AdicionarParametro("@INdatDataCadastro", vendedor.DataCadastro);


                return AcessoDados.ExecutarScalar("uspCadastrarVendedor", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Alterar(Vendedor vendedor)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDPessoa", vendedor.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", vendedor.Pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", vendedor.Pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", vendedor.Pessoa.Ativo);
                AcessoDados.AdicionarParametro("@INdatDataCadastro", vendedor.DataCadastro);


                return AcessoDados.ExecutarScalar("uspCadastrarVendedor", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Excluir(Vendedor vendedor)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDPessoa", vendedor.Pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", vendedor.Pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", vendedor.Pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", vendedor.Pessoa.Ativo);
                AcessoDados.AdicionarParametro("@INdatDataCadastro", vendedor.DataCadastro);


                return AcessoDados.ExecutarScalar("uspCadastrarVendedor", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }


        public VendedorCollection PesquisarVendedor(string VMPesquisa, int? IDPessoa, bool? ativo)
        {
            VendedorCollection vendedorCollection = new VendedorCollection();
            AcessoDados.LimparParametro();
            AcessoDados.AdicionarParametro("@INvchNome", VMPesquisa);
            AcessoDados.AdicionarParametro("@INbitAtivo", ativo);

            using (DataTable dtbRegistro = AcessoDados.GetDataTable("uspPesquisarVendedor", CommandType.StoredProcedure))
            {
                foreach (DataRow dtrItem in dtbRegistro.Rows)
                    vendedorCollection.Add(CarregarItem(dtrItem));
            }

            return vendedorCollection;
        }

        private Vendedor CarregarItem(DataRow dtrItem)
        {
            Vendedor vendedor = new Vendedor();
            VMDataRow dtr = new VMDataRow(dtrItem);

            vendedor.Pessoa = new Pessoa
            {
                IDPessoa = dtr.GetInt("IDPessoa"),
                Nome = dtr.GetStr("Nome"),
                CpfCnpj = dtr.GetDec("CpfCnpj"),
                Ativo = dtr.GetBoo("Ativo")
            };
            vendedor.DataCadastro = dtr.GetDat("DataCadastro");

            return vendedor;
        }

        
    }
}
