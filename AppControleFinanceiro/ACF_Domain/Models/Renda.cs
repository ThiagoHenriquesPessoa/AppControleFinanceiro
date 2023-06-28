using System.ComponentModel.DataAnnotations;

namespace AppControleFinanceiro.ACF_Domain.Models
{
    public class Renda
    {
        [Key]
        public Int64 IdRenda { get; set; }

        public double ValorRenda { get; set; }
        public string TipoRenda { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}