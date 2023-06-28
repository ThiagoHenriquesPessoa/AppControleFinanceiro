using AppControleFinanceiro.ACF_Domain.Models;
using System.Data;

namespace AppControleFinanceiro.ACF_Business.InterfaceBusiness
{
    public interface IRendaBusiness
    {
        void InsertRenda(Renda renda);

        double GetRendaTotal();

        DataTable GetAllRendaPorData(DateTime inicio, DateTime fim);

        double GetRendaAnoAtualall();

        double GetRendaMesAtualAll();

        void UpdateRenda(Renda renda);

        void DeleteRenda(Int64 idRenda);
    }
}