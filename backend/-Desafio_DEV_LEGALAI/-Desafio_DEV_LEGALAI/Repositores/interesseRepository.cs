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
        private string stringConexao = "Data Source=DESKTOP-P4LGFHE;initial catalog=Desafio_Legal;integrated security=true";

        public InteresseDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(InteresseDomain novoInteresse)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
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
