using _Desafio_DEV_LEGALAI.Domains;

namespace _Desafio_DEV_LEGALAI.Interfaces
{
    public interface IEmpresaRepository
    {
        /// <summary>
        /// Lista todas as Empresas
        /// </summary>
        /// <returns>Lista de Empresas </returns>
        List<EmpresaDomain> ListarEmpresas();

        /// <summary>
        /// Buscar uma Empresa pelo seu id
        /// </summary>
        /// <param name="id">id do Empresa que será buscado</param>
        /// <returns>o objeto buscado</returns>
        EmpresaDomain BuscarPorId(int id);


        void Cadastrar(EmpresaDomain novoEmpresa);

        /// <summary>
        /// Deleta uma Empresa
        /// </summary>
        /// <param name="id">id da Empresa deletada</param>
        void Deletar(int id);
    }
}
