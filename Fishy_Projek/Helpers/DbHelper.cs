using System;
using Npgsql;

namespace Fishy_Projek
{
    public class DbHelper
    {
        private static string connectionString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=update_fihsy3_public;" +
            "Username=postgres;" +
            "Password=valensari16;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}