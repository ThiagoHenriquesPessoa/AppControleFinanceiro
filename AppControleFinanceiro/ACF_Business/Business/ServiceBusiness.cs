using AppControleFinanceiro.ACF_Business.InterfaceBusiness;

namespace AppControleFinanceiro.ACF_Business.Business
{
    public class ServiceBusiness : IServiceBusiness
    {
        public string MesAtual(int mes)
        {
            string mesAtual = "";
            switch (mes)
            {
                case 1:
                    mesAtual = "janeiro";
                    break;

                case 2:
                    mesAtual = "fevereiro";
                    break;

                case 3:
                    mesAtual = "março";
                    break;

                case 4:
                    mesAtual = "abril";
                    break;

                case 5:
                    mesAtual = "maio";
                    break;

                case 6:
                    mesAtual = "junho";
                    break;

                case 7:
                    mesAtual = "julho";
                    break;

                case 8:
                    mesAtual = "agosto";
                    break;

                case 9:
                    mesAtual = "setembro";
                    break;

                case 10:
                    mesAtual = "outubro";
                    break;

                case 11:
                    mesAtual = "novembro";
                    break;

                case 12:
                    mesAtual = "dezembro";
                    break;
            }
            return mesAtual;
        }
    }
}