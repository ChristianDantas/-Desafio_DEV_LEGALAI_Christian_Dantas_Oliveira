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

        void Cadastrar(EmpresaDomain novoEmpresa);

        EmpresaDomain BuscarPorID(int id);

    }
}
