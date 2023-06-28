using AppControleFinanceiro.ACF_Domain.Models;
using System.Data;

namespace AppControleFinanceiro.ACF_Business.InterfaceBusiness
{
    public interface IDespesaBusiness
    {
        void InsertDespesa(Despesa despesa);

        double GetDespesaTotal();

        double GetDespesaAnoAtualAll();

        double GetValorDespesaMesAtualAll();

        DataTable GetDespesaMesAtualAll();

        DataTable GetDespesaNaoPagasMesAtualAll();

        DataTable GetAllDespesaPorData(DateTime inicio, DateTime fim);

        void UpdateDespesa(Despesa despesa);

        void DeleteDespesa(Int64 idDespesa);
    }
}