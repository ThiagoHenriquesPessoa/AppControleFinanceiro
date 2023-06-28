using AppControleFinanceiro.ACF_Domain.Models;
using AppControleFinanceiro.ACF_Infrastructure;
using AppControleFinanceiro.ACF_Repository.InterfaceRepository;
using Dapper;

namespace AppControleFinanceiro.ACF_Repository.Repository
{
    public class RendaRepository : IRendaRepository
    {
        public void InsertRenda(Renda renda)
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        ValorRenda = renda.ValorRenda,
                        TipoRenda = renda.TipoRenda,
                        DataEntrada = renda.DataEntrada
                    };
                    var sql = "INSERT INTO [Renda] ([ValorRenda] ,[TipoRenda] ,[DataEntrada]) VALUES  (@ValorRenda, @TipoRenda, @DataEntrada);";
                    connection.Query(sql, parameter);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<double> GetRendaAll()
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var ListaValores = connection.Query<double>("SELECT ValorRenda FROM [Renda];").ToList();
                    return ListaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Renda> GetAllRendaPorData(DateTime inicail, DateTime fim)
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
                    var sql = "SELECT * FROM [Renda] WHERE DataEntrada >= @param0 and DataEntrada < @param1;";
                    var ListaRenda = connection.Query<Renda>(sql, parameter).ToList();
                    return ListaRenda;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<double> GetRendaAnoAtualall()
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
                    var sql = "SELECT ValorRenda FROM [Renda] WHERE DataEntrada > @param0 and DataEntrada< @param1;";
                    var ListaValores = connection.Query<double>(sql, parameter).ToList();
                    return ListaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<double> GetRendaMesAtualAll()
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
                    var sql = "SELECT ValorRenda FROM [Renda] WHERE DataEntrada >= @param0 and DataEntrada < @param1;";
                    var ListaValores = connection.Query<double>(sql, parameter).ToList();
                    return ListaValores;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateRenda(Renda renda)
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        IdRenda = renda.IdRenda,
                        ValorRenda = renda.ValorRenda,
                        TipoRenda = renda.TipoRenda,
                        DataEntrada = renda.DataEntrada
                    };
                    var sql = "UPDATE [Renda] SET [ValorRenda] = @ValorRenda, [TipoRenda] = @TipoRenda, [DataEntrada] = @DataEntrada WHERE [IdRenda] == @IdRenda;";
                    connection.Query(sql, parameter);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteRenda(Int64 idRenda)
        {
            try
            {
                using (var connection = WinFormDbContext.DbConnection())
                {
                    var parameter = new
                    {
                        IdRenda = idRenda
                    };
                    var sql = "DELETE FROM [Renda] WHERE [IdRenda] == @IdRenda;";
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