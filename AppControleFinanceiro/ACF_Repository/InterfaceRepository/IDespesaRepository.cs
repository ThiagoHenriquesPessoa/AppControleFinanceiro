using AppControleFinanceiro.ACF_Domain.Models;

namespace AppControleFinanceiro.ACF_Repository.InterfaceRepository
{
    public interface IDespesaRepository
    {
        void InsertDespesa(Despesa despesa);

        List<double> GetValorDespesaAll();

        List<double> GetValorDespesaAnoAtualAll();

        List<double> GetValorDespesaMesAtualAll();

        List<Despesa> GetDespesaMesAtualAll();

        List<Despesa> GetAllDespesaPorData(DateTime inicail, DateTime fim);

        void UpdateDespesa(Despesa despesa);

        void DeleteDespesa(Int64 idDespesa);
    }
}