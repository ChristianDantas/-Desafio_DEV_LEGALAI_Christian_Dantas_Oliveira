using System.Data.SqlClient;
using _Desafio_DEV_LEGALAI.Domains;
using _Desafio_DEV_LEGALAI.Interfaces;

namespace _Desafio_DEV_LEGALAI.Repositores
{
    public class EmpresaRepository : IEmpresaRepository
    {
        /// <summary>
        /// Sring de conexão com o banco de dados que recebe os parametros
        /// Data Source = Nome do Servidor
        /// Initial Catalog = nome do banco de dados
        /// inntegrated security= true =faz a autenticação com o usuario do sistema
        /// </summary>
        private string stringConexao = "Data Source=sql2.cajmkci64qst.us-east-1.rds.amazonaws.com;initial catalog=Desafio_Legal; user Id=admin; pwd=12345678";

        public EmpresaDomain BuscarPorID(int id)
        {
           using(SqlConnection con = new(stringConexao))
            {
                string querySelectById = "SELECT idEmpresas, idInteresse, nomeEmpresa, Localizacao FROM Empresas WHERE idEmpresas = @id";
                con.Open();
                using (SqlCommand cmd = new(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            EmpresaDomain empresa = new()
                            {
                                idEmpresa = Convert.ToInt32(rdr[0]),
                                idInteresse = Convert.ToInt32(rdr[1]),
                                nomeEmpresa = rdr[2].ToString(),
                                Localizacao = rdr[3].ToString()
                            };
                            return empresa;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void Cadastrar(EmpresaDomain novoEmpresa)
        {
            using (SqlConnection con = new(stringConexao))
            {
                string queryInsert = "INSERT INTO Empresas (idInteresse, nomeEmpresas, Localizacao) VALUES (@idInteresse, @nomeEmpresa, @Localizacao)";
                using (SqlCommand cmd = new(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@idInteresse", novoEmpresa.idInteresse);
                    cmd.Parameters.AddWithValue("@nomeEmpresa", novoEmpresa.nomeEmpresa);
                    cmd.Parameters.AddWithValue("@Localizacao", novoEmpresa.Localizacao);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<EmpresaDomain> ListarEmpresas()
        {
            List<EmpresaDomain> listaEmpresas = new List<EmpresaDomain>();

            using (SqlConnection con = new(stringConexao))
            {
                string querySelectAll = "SELECT idEmpresas, idInteresse, nomeEmpresa, Localizacao FROM Empresas";
                con.Open();
                using (SqlCommand cmd = new(querySelectAll, con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            EmpresaDomain empresa = new()
                            {
                                idEmpresa = Convert.ToInt32(rdr[0]),
                                idInteresse = Convert.ToInt32(rdr[1]),
                                nomeEmpresa = rdr[2].ToString(),
                                Localizacao = rdr[3].ToString()
                            };
                            listaEmpresas.Add(empresa);
                        }
                    }
                }
            }
            return listaEmpresas;
        }
    }
}
