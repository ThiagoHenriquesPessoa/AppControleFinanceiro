using AppControleFinanceiro.ACF_Business.InterfaceBusiness;
using AppControleFinanceiro.ACF_Domain.Models;
using AppControleFinanceiro.ACF_Repository.InterfaceRepository;
using System.Data;

namespace AppControleFinanceiro.ACF_Business.Business
{
    public class DespesaBusiness : IDespesaBusiness
    {
        private readonly IDespesaRepository _despesaRepository;

        public DespesaBusiness(IDespesaRepository despesaRepository)
        {
            _despesaRepository = despesaRepository;
        }

        public void InsertDespesa(Despesa despesa)
        {
            Int64 parcelas = despesa.QuantidadeParcelas;
            double valor = despesa.ValorDespesa / parcelas;
            despesa.ValorDespesa = valor;
            for (int i = 1; i <= parcelas; i++)
            {
                despesa.DataVencimentoDespesa = i == 1 ? despesa.DataVencimentoDespesa : despesa.DataVencimentoDespesa.AddMonths(1);
                despesa.ParcelaAtual = i;
                _despesaRepository.InsertDespesa(despesa);
            }
        }

        public double GetDespesaTotal()
        {
            double valorTotal = 0;
            var listValores = _despesaRepository.GetValorDespesaAll();
            foreach (var valor in listValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public double GetDespesaAnoAtualAll()
        {
            double valorTotal = 0;
            var listValores = _despesaRepository.GetValorDespesaAnoAtualAll();
            foreach (var valor in listValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public double GetValorDespesaMesAtualAll()
        {
            double valorTotal = 0;
            var listValores = _despesaRepository.GetValorDespesaMesAtualAll();
            foreach (var valor in listValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public DataTable GetDespesaNaoPagasMesAtualAll()
        {
            var listDespesas = _despesaRepository.GetDespesaMesAtualAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdDespesa", typeof(Int64));
            dt.Columns.Add("Tipo de despesa", typeof(string));
            dt.Columns.Add("Valor da despesa", typeof(string));
            dt.Columns.Add("Formato usado", typeof(string));
            foreach (var despesa in listDespesas)
            {
                if (despesa.DespesaPaga == false)
                {
                    dt.Rows.Add(
                        despesa.IdDespesa,
                        despesa.TipoDespesa,
                        despesa.ValorDespesa.ToString("C"),
                        despesa.FormaPagamento);
                }
            }
            return dt;
        }

        public DataTable GetDespesaMesAtualAll()
        {
            var listDespesas = _despesaRepository.GetDespesaMesAtualAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdDespesa", typeof(Int64));
            dt.Columns.Add("Valor da despesa", typeof(string));
            dt.Columns.Add("Tipo de despesa", typeof(string));
            dt.Columns.Add("Quantidade de parcelas", typeof(Int64));
            dt.Columns.Add("Parcela atual", typeof(Int64));
            dt.Columns.Add("Criação da despesa", typeof(DateTime));
            dt.Columns.Add("Vencimento da despesa", typeof(DateTime));
            dt.Columns.Add("Despesa Paga", typeof(bool));
            dt.Columns.Add("Forma de pagamento", typeof(string));
            foreach (var despesa in listDespesas)
            {
                dt.Rows.Add(
                        despesa.IdDespesa,
                        despesa.ValorDespesa.ToString("C"),
                        despesa.TipoDespesa,
                        despesa.QuantidadeParcelas,
                        despesa.ParcelaAtual,
                        despesa.DataCriacaoDespesa,
                        despesa.DataVencimentoDespesa,
                        despesa.DespesaPaga,
                        despesa.FormaPagamento);
            }
            return dt;
        }

        public DataTable GetAllDespesaPorData(DateTime inicio, DateTime fim)
        {
            var listDespesas = _despesaRepository.GetAllDespesaPorData(inicio, fim);
            DataTable dt = new DataTable();
            dt.Columns.Add("IdDespesa", typeof(Int64));
            dt.Columns.Add("Valor da despesa", typeof(string));
            dt.Columns.Add("Tipo de despesa", typeof(string));
            dt.Columns.Add("Quantidade de parcelas", typeof(Int64));
            dt.Columns.Add("Parcela atual", typeof(Int64));
            dt.Columns.Add("Criação da despesa", typeof(DateTime));
            dt.Columns.Add("Vencimento da despesa", typeof(DateTime));
            dt.Columns.Add("Despesa Paga", typeof(bool));
            dt.Columns.Add("Forma de pagamento", typeof(string));
            foreach (var despesa in listDespesas)
            {
                dt.Rows.Add(
                        despesa.IdDespesa,
                        despesa.ValorDespesa.ToString("C"),
                        despesa.TipoDespesa,
                        despesa.QuantidadeParcelas,
                        despesa.ParcelaAtual,
                        despesa.DataCriacaoDespesa,
                        despesa.DataVencimentoDespesa,
                        despesa.DespesaPaga,
                        despesa.FormaPagamento);
            }
            return dt;
        }

        public void UpdateDespesa(Despesa despesa)
        {
            _despesaRepository.UpdateDespesa(despesa);
        }

        public void DeleteDespesa(Int64 idDespesa)
        {
            _despesaRepository.DeleteDespesa(idDespesa);
        }
    }
}