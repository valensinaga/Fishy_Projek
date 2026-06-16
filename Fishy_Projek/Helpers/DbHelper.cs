using Fishy_Projek.Helpers;
using Npgsql;

namespace Fishy_Projek.Helpers
{
    public static class DbHelper
    {
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(DbConfig.ConnectionString);
        }
    }
}