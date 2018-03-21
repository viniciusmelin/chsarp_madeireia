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
    public class NegPessoa
    {
        AcessoDados.AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();

        public string Inserir(Pessoa pessoa)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Inserir);
                AcessoDados.AdicionarParametro("@INintIDPessoa", pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", pessoa.Ativo);


                return AcessoDados.ExecutarScalar("uspCadastrarPessoa", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: "+ ex.Message);
            }
        }

        public string Alterar(Pessoa pessoa)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Alterar);
                AcessoDados.AdicionarParametro("@INintIDPessoa", pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", pessoa.Ativo);


                return AcessoDados.ExecutarScalar("uspCadastrarPessoa", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }

        public string Excluir(Pessoa pessoa)
        {
            try
            {
                AcessoDados.LimparParametro();
                AcessoDados.AdicionarParametro("@INintAcao", (int)AcaoBD.Excluir);
                AcessoDados.AdicionarParametro("@INintIDPessoa", pessoa.IDPessoa);
                AcessoDados.AdicionarParametro("@INvchNome", pessoa.Nome);
                AcessoDados.AdicionarParametro("@INdecCpfCnpj", pessoa.CpfCnpj);
                AcessoDados.AdicionarParametro("@INbitAtivo", pessoa.Ativo);


                return AcessoDados.ExecutarScalar("uspCadastrarPessoa", CommandType.StoredProcedure).ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }
    }
}
