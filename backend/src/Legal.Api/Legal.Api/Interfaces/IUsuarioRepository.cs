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

        void Cadastrar(UsuarioDomain novoUsuario);

        UsuarioDomain BuscarPorID(int id);

    }
}
