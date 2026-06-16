using Npgsql;

namespace Fishy_Projek.Helpers
{
    public class DbHelper
    {
        private static string connectionString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=FISHY_5;" +
            "Username=postgres;" +
            "Password=valensari16;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}