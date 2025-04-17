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

        void Cadastrar(InteresseDomain novoInteresse);

       
    }
}
