﻿using System.Data.SqlClient;
using _Desafio_DEV_LEGALAI.Domains;
using _Desafio_DEV_LEGALAI.Interfaces;

namespace _Desafio_DEV_LEGALAI.Repositores
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Sring de conexão com o banco de dados que recebe os parametros
        /// Data Source = Nome do Servidor
        /// Initial Catalog = nome do banco de dados
        /// inntegrated security= true =faz a autenticação com o usuario do sistema
        /// </summary>
        private string stringConexao = "Data Source=sqlserver.c1agskouw8ei.sa-east-1.rds.amazonaws.com;initial catalog=Desafio_Legal; user Id=admin; pwd=12345678";

        public UsuarioDomain BuscarPorID(int id)
        {
            using(SqlConnection con = new(stringConexao))
            {
                string querySelectById = "SELECT idUsuario, idInteresse, nomeUsuario, Localizacao FROM Usuario WHERE idUsuario = @id";
                con.Open();
                using (SqlCommand cmd = new(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            UsuarioDomain usuario = new()
                            {
                                idUsuario = Convert.ToInt32(rdr[0]),
                                idInteresse = Convert.ToInt32(rdr[1]),
                                nomeUsuario = rdr[2].ToString(),
                                Localizacao = rdr[3].ToString()
                            };
                            return usuario;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void Cadastrar(UsuarioDomain novoUsuario)
        {
            using (SqlConnection con = new(stringConexao))
            {
                string queryInsert = "INSERT INTO Usuario (idInteresse, nomeUsuario, Localizacao) VALUES (@idInteresse, @nomeUsuario, @Localizacao)";
                using (SqlCommand cmd = new(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@idInteresse", novoUsuario.idInteresse);
                    cmd.Parameters.AddWithValue("@nomeUsuario", novoUsuario.nomeUsuario);
                    cmd.Parameters.AddWithValue("@Localizacao", novoUsuario.Localizacao);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<UsuarioDomain> ListarUsuario()
        {
            using (SqlConnection con = new(stringConexao))
            {
                List<UsuarioDomain> listaUsuario = new List<UsuarioDomain>();
                string querySelectAll = "SELECT idUsuario, idInteresse, nomeUsuario, Localizacao FROM Usuario";
                con.Open();
                using (SqlCommand cmd = new(querySelectAll, con))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            UsuarioDomain usuario = new()
                            {
                                idUsuario = Convert.ToInt32(rdr[0]),
                                idInteresse = Convert.ToInt32(rdr[1]),
                                nomeUsuario = rdr[2].ToString(),
                                Localizacao = rdr[3].ToString()
                            };
                            listaUsuario.Add(usuario);
                        }
                    }
                }
                return listaUsuario;
            }
        }
    }
}
