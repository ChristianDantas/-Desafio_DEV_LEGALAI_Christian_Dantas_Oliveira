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
        private string stringConexao = "Data Source=DESKTOP-P4LGFHE;initial catalog=Desafio_Legal;integrated security=true";
        public void Cadastrar(EmpresaDomain novoEmpresa)
        {
            using (SqlConnection con = new(stringConexao))
            {
                string queryInsert = "INSERT INTO Empresa (idInteresse, nomeEmpresa, Localização) VALUES (@idInteresse, @nomeEmpresa, @Localização)";
                using (SqlCommand cmd = new(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@idInteresse", novoEmpresa.idInteresse);
                    cmd.Parameters.AddWithValue("@nomeEmpresa", novoEmpresa.nomeEmpresa);
                    cmd.Parameters.AddWithValue("@Localização", novoEmpresa.Localização);
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
                string querySelectAll = "SELECT idEmpresa, idInteresse, nomeEmpresa, Localização FROM Empresa";
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
                                Localização = rdr[3].ToString()
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
