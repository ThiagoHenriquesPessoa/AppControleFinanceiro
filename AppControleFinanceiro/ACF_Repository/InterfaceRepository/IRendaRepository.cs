using AppControleFinanceiro.ACF_Domain.Models;

namespace AppControleFinanceiro.ACF_Repository.InterfaceRepository
{
    public interface IRendaRepository
    {
        void InsertRenda(Renda renda);

        List<double> GetRendaAll();

        List<Renda> GetAllRendaPorData(DateTime inicail, DateTime fim);

        List<double> GetRendaAnoAtualall();

        List<double> GetRendaMesAtualAll();

        void UpdateRenda(Renda renda);

        void DeleteRenda(Int64 idRenda);
    }
}