using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataLibrary
{
    public class DataAccess
    {
        public static List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sql, parameters).ToList();

                return rows;
            }
        }
    }
}
