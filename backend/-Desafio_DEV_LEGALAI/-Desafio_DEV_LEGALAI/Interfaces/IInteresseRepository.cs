using _Desafio_DEV_LEGALAI.Domains;

namespace _Desafio_DEV_LEGALAI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório InteresseRepository
    /// </summary>
    public interface IInteresseRepository
    {
        /// <summary>
        /// Lista todos os Interesses
        /// </summary>
        /// <returns>Lista de interesses</returns>
        List<InteresseDomain> ListarInteresse();

        /// <summary>
        /// Buscar um interesse pelo seu id
        /// </summary>
        /// <param name="id">id do Interesse que será buscado</param>
        /// <returns>o objeto buscado</returns>
        InteresseDomain BuscarPorId(int id);

 
        void Cadastrar(InteresseDomain novoInteresse);

        /// <summary>
        /// Deleta um interesse
        /// </summary>
        /// <param name="id">id do interesse deletado</param>
        void Deletar(int id);
    }
}
