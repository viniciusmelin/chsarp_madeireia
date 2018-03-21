using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace SlnEstagio.AcessoDados
{
    public class AcessoDadosSqlServer
    {
        private SqlParameterCollection sqlParameterCollection;

        public AcessoDadosSqlServer()
        {
            this.sqlParameterCollection = new SqlCommand().Parameters;
        }


        public SqlConnection GetConexao()
        {
            try
            {
                return new SqlConnection(Properties.Settings.Default.ESMPLUSConnectionString);
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao abrir conexão com o banco de dados.\nMotivo: " + ex.Message);
            }

        }

        public void AdicionarParametro(SqlParameter sqlParameter)
        {
            this.sqlParameterCollection.Add(sqlParameter);
        }

        public void AdicionarParametro(string nomeParametro, object valorParametro)
        {
            this.sqlParameterCollection.Add(new SqlParameter
            { ParameterName = nomeParametro,
              Value = valorParametro
            });
        }

        public void AdicionarParametro(string nomeParametro, int valorParametro)
        {
            this.sqlParameterCollection.Add(new SqlParameter
            {
                ParameterName = nomeParametro,
                Value = valorParametro
            });
        }
        public void AdicionarParametro(string nomeParametro, string valorParametro)
        {
            this.sqlParameterCollection.Add(new SqlParameter
            {
                ParameterName = nomeParametro,
                Value = valorParametro
            });
        }
        public void AdicionarParametro(string nomeParametro, bool valorParametro)
        {
            this.sqlParameterCollection.Add(new SqlParameter
            {
                ParameterName = nomeParametro,
                Value = valorParametro
            });
        }

        public void AdicionarParametro(string nomeParametro, DateTime valorParametro)
        {
            this.sqlParameterCollection.Add(new SqlParameter
            {
                ParameterName = nomeParametro,
                Value = valorParametro
            });
        }

        public void AdicionarParametro(string nomeParametro, decimal valorParametro)
        {
            this.sqlParameterCollection.Add(new SqlParameter
            {
                ParameterName = nomeParametro,
                Value = valorParametro
            });
        }
        public void LimparParametro()
        {
            this.sqlParameterCollection.Clear();
        }

        private void AdicionarParametrosAoComando(SqlCommand sqlCommand)
        {
            foreach (SqlParameter item in this.sqlParameterCollection)
            {
                sqlCommand.Parameters.Add(new SqlParameter(item.ParameterName, item.Value));
            }
        }

        public object ExecutarScalar(string comandoSql, CommandType tipoComando)
        {
            try
            {
                using (SqlConnection sqlConnection = GetConexao())
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = comandoSql;
                    sqlCommand.CommandType = tipoComando;
                    sqlCommand.CommandTimeout = 7200;
                    AdicionarParametrosAoComando(sqlCommand);
                    return sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Falha ao executar comando no banco de dados.\nMotivo: " + ex.Message);
            }
        }


        public DataTable GetDataTable(string comandoSql, CommandType tipoComando)
        {
            using (SqlConnection sqlConnection = GetConexao())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = comandoSql;
                sqlCommand.CommandType = tipoComando;
                sqlCommand.CommandTimeout = 7200;
                AdicionarParametrosAoComando(sqlCommand);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                return dataSet.Tables[0];
            }
        }

        public DataSet GetDataTables(string comandoSql, CommandType tipoComando)
        {
            using (SqlConnection sqlConnection = GetConexao())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = comandoSql;
                sqlCommand.CommandType = tipoComando;
                sqlCommand.CommandTimeout = 7200;
                AdicionarParametrosAoComando(sqlCommand);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                return dataSet;
            }
        }

        public DataSet GetDataSet(string strNomeStoredProcedure)
        {
            return GetDataSet(strNomeStoredProcedure);
        }
    }
}
