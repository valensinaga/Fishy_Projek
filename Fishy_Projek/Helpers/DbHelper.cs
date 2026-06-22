using System;
using Npgsql;
using Fishy_Projek.Helpers; 

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

// WARNING jangan diganti isinya, tolong isi user password nama db temen-temen di File DbConfig.cs + masukkan ke .gitignore . kaya yang kuketik di WA grup