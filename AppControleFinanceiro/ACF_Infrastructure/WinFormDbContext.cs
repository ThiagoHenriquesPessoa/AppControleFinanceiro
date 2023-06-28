using System.Data.SQLite;

namespace AppControleFinanceiro.ACF_Infrastructure
{
    public class WinFormDbContext
    {
        public static string path = Directory.GetCurrentDirectory() + "\\WinFormsDBFinancas.sqlite";
        public static SQLiteConnection sQLiteconnection;

        public static SQLiteConnection DbConnection()
        {
            sQLiteconnection = new SQLiteConnection("Data Source=" + path);
            sQLiteconnection.Open();
            return sQLiteconnection;
        }
    }
}