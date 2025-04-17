using _Desafio_DEV_LEGALAI.Domains;

namespace _Desafio_DEV_LEGALAI.Interfaces
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os Usuario
        /// </summary>
        /// <returns>Lista de Usuario</returns>
        List<UsuarioDomain> ListarUsuario();

        /// <summary>
        /// Buscar um Usuario pelo seu id
        /// </summary>
        /// <param name="id">id do Usuario que será buscado</param>
        /// <returns>o objeto buscado</returns>
        UsuarioDomain BuscarPorId(int id);


        void Cadastrar(UsuarioDomain novoUsuario);

        /// <summary>
        /// Deleta um usuario
        /// </summary>
        /// <param name="id">id do Usuario deletado</param>
        void Deletar(int id);
    }
}
