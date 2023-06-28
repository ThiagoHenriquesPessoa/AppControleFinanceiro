using AppControleFinanceiro.ACF_Domain.Models;
using AppControleFinanceiro.ACF_Infrastructure;
using AppControleFinanceiro.ACF_Repository.InterfaceRepository;
using Dapper;

namespace AppControleFinanceiro.ACF_Repository.Repository
{
    public class DespesaRepository : IDespesaRepository
    {
        public void InsertDespesa(Despesa despesa)
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        ValorDespesa = despesa.ValorDespesa,
                        TipoDespesa = despesa.TipoDespesa,
                        QuantidadeParcelas = despesa.QuantidadeParcelas,
                        ParcelaAtual = despesa.ParcelaAtual,
                        DataCriacaoDespesa = despesa.DataCriacaoDespesa,
                        DataVencimentoDespesa = despesa.DataVencimentoDespesa,
                        DespesaPaga = despesa.DespesaPaga,
                        FormaPagamento = despesa.FormaPagamento
                    };
                    var sql = "INSERT INTO [Despesa] ([ValorDespesa], [TipoDespesa], [QuantidadeParcelas], [ParcelaAtual], [DataCriacaoDespesa], [DataVencimentoDespesa], [DespesaPaga], [FormaPagamento]) VALUES  (@ValorDespesa, @TipoDespesa, @QuantidadeParcelas, @ParcelaAtual, @DataCriacaoDespesa, @DataVencimentoDespesa, @DespesaPaga, @FormaPagamento);";
                    connection.Query(sql, parameter);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<double> GetValorDespesaAll()
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var listaValores = connection.Query<double>("SELECT ValorDespesa FROM [Despesa];").ToList();
                    return listaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<double> GetValorDespesaAnoAtualAll()
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        param0 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-01-01 00:00:00"),
                        param1 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-12-31 23:59:59")
                    };
                    var sql = "SELECT ValorDespesa FROM [Despesa] WHERE DataVencimentoDespesa > @param0 and DataVencimentoDespesa < @param1;";
                    var listaValores = connection.Query<double>(sql, parameter).ToList();
                    return listaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<double> GetValorDespesaMesAtualAll()
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        param0 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-" + DateTime.Now.Date.Month.ToString() + "-01 00:00:00"),
                        param1 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-" + DateTime.Now.Date.AddMonths(1).Month + "-01 00:00:00")
                    };
                    var sql = "SELECT ValorDespesa FROM [Despesa] WHERE DataVencimentoDespesa >= @param0 and DataVencimentoDespesa < @param1;";
                    var listaValores = connection.Query<double>(sql, parameter).ToList();
                    return listaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Despesa> GetDespesaMesAtualAll()
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        param0 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-" + DateTime.Now.Date.Month.ToString() + "-01 00:00:00"),
                        param1 = Convert.ToDateTime(DateTime.Now.Date.Year.ToString() + "-" + DateTime.Now.Date.AddMonths(1).Month + "-01 00:00:00")
                    };
                    var sql = "SELECT * FROM [Despesa] WHERE DataVencimentoDespesa >= @param0 and DataVencimentoDespesa < @param1;";
                    var listaDespesas = connection.Query<Despesa>(sql, parameter).ToList();
                    return listaDespesas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Despesa> GetAllDespesaPorData(DateTime inicail, DateTime fim)
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        param0 = Convert.ToDateTime(inicail.ToString("yyyy-MM-dd 00:00:00")),
                        param1 = Convert.ToDateTime(fim.ToString("yyyy-MM-dd 23:59:00"))
                    };
                    var sql = "SELECT * FROM [Despesa] WHERE DataVencimentoDespesa >= @param0 and DataVencimentoDespesa < @param1;";
                    var listaDespesas = connection.Query<Despesa>(sql, parameter).ToList();
                    return listaDespesas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateDespesa(Despesa despesa)
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        IdDespesa = despesa.IdDespesa,
                        ValorDespesa = despesa.ValorDespesa,
                        TipoDespesa = despesa.TipoDespesa,
                        QuantidadeParcelas = despesa.QuantidadeParcelas,
                        ParcelaAtual = despesa.ParcelaAtual,
                        DataCriacaoDespesa = despesa.DataCriacaoDespesa,
                        DataVencimentoDespesa = despesa.DataVencimentoDespesa,
                        DespesaPaga = despesa.DespesaPaga,
                        FormaPagamento = despesa.FormaPagamento
                    };
                    var sql = "UPDATE [Despesa] SET [ValorDespesa] = @ValorDespesa, [TipoDespesa] = @TipoDespesa, [QuantidadeParcelas] = @QuantidadeParcelas, [ParcelaAtual] = @ParcelaAtual, [DataCriacaoDespesa] = @DataCriacaoDespesa, [DataVencimentoDespesa] = @DataVencimentoDespesa, [DespesaPaga] = @DespesaPaga, [FormaPagamento] = @FormaPagamento WHERE [IdDespesa] == @IdDespesa;";
                    connection.Query(sql, parameter);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteDespesa(Int64 idDespesa)
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        IdDespesa = idDespesa
                    };
                    var sql = "DELETE FROM [Despesa] WHERE [IdDespesa] == @IdDespesa;";
                    connection.Query(sql, parameter);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}