using System.Data.SqlClient;
using _Desafio_DEV_LEGALAI.Domains;
using _Desafio_DEV_LEGALAI.Interfaces;

namespace _Desafio_DEV_LEGALAI.Repositores
{
    /// <summary>
    /// Classe responsavel pelo repositorio de Interesse
    /// </summary>
    public class interesseRepository : IInteresseRepository
    {
        /// <summary>
        /// Sring de conexão com o banco de dados que recebe os parametros
        /// Data Source = Nome do Servidor
        /// Initial Catalog = nome do banco de dados
        /// inntegrated security= true =faz a autenticação com o usuario do sistema
        /// </summary>
        private string stringConexao = "Data Source=sqlserver.c1agskouw8ei.sa-east-1.rds.amazonaws.com;initial catalog=Desafio_Legal; user Id=admin; pwd=12345678";

        public InteresseDomain BuscarPorID(int id)
        {
            using(SqlConnection con = new(stringConexao))
            {
                string querySelectById = "SELECT idInteresse, nomeInteresse FROM Interesse WHERE idInteresse = @ID";
                con.Open();
                using (SqlCommand cmd = new(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        InteresseDomain interesseBuscado = new()
                        {
                            idInteresse = Convert.ToInt32(rdr["idInteresse"]),
                            nomeInteresse = rdr["nomeInteresse"].ToString()
                        };
                        return interesseBuscado;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void Cadastrar(InteresseDomain novoInteresse)
        {
            using (SqlConnection con = new(stringConexao))
            {
                string queryInsert = "INSERT INTO Interesse (nomeInteresse) VALUES (@Nome)";
                using (SqlCommand cmd = new(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@nomeInteresse", novoInteresse.nomeInteresse);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<InteresseDomain> ListarInteresse()
        {
            // Cria a lista de interesse
            List<InteresseDomain> listaInteresse = new();

            // Define a conexão com o banco de dados
            using (SqlConnection con = new(stringConexao))
            {
                // Define a consulta SQL
                string querySelectAll = "SELECT idInteresse, nomeInteresse FROM Interesse";

                // Abre a conexão
                con.Open();

                // Define o comando a ser executado
                using (SqlCommand cmd = new(querySelectAll, con))
                {
                    // Executa o comando e lê os dados retornados
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            // Cria um objeto InteresseDomain e preenche com os dados do banco
                            InteresseDomain interesse = new()
                            {
                                idInteresse = Convert.ToInt32(rdr["idInteresse"]),
                                nomeInteresse = rdr["nomeInteresse"].ToString()
                            };

                            // Adiciona o objeto à lista
                            listaInteresse.Add(interesse);
                        }
                    }
                }
            }

            // Retorna a lista de interesses
            return listaInteresse;
        }
    }
}
