using AppControleFinanceiro.ACF_Business.InterfaceBusiness;
using AppControleFinanceiro.ACF_Domain.Models;
using AppControleFinanceiro.ACF_Repository.InterfaceRepository;
using System.Data;

namespace AppControleFinanceiro.ACF_Business.Business
{
    public class RendaBusiness : IRendaBusiness
    {
        private readonly IRendaRepository _rendaRepository;

        public RendaBusiness(IRendaRepository rendaRepository)
        {
            _rendaRepository = rendaRepository;
        }

        public void InsertRenda(Renda renda)
        {
            _rendaRepository.InsertRenda(renda);
        }

        public double GetRendaTotal()
        {
            double valorTotal = 0;
            var listaValores = _rendaRepository.GetRendaAll();
            foreach (var valor in listaValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public DataTable GetAllRendaPorData(DateTime inicio, DateTime fim)
        {
            var listDespesas = _rendaRepository.GetAllRendaPorData(inicio, fim);
            DataTable dt = new DataTable();
            dt.Columns.Add("IdRenda", typeof(Int64));
            dt.Columns.Add("Valor da renda", typeof(string));
            dt.Columns.Add("Tipo de renda", typeof(string));
            dt.Columns.Add("data de entrada", typeof(DateTime));
            foreach (var despesa in listDespesas)
            {
                dt.Rows.Add(
                        despesa.IdRenda,
                        despesa.ValorRenda.ToString("C"),
                        despesa.TipoRenda,
                        despesa.DataEntrada);
            }
            return dt;
        }

        public double GetRendaAnoAtualall()
        {
            double valorTotal = 0;
            var listaValores = _rendaRepository.GetRendaAnoAtualall();
            foreach (var valor in listaValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public double GetRendaMesAtualAll()
        {
            double valorTotal = 0;
            var listaValores = _rendaRepository.GetRendaMesAtualAll();
            foreach (var valor in listaValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public void UpdateRenda(Renda renda)
        {
            _rendaRepository.UpdateRenda(renda);
        }

        public void DeleteRenda(Int64 idRenda)
        {
            _rendaRepository.DeleteRenda(idRenda);
        }
    }
}