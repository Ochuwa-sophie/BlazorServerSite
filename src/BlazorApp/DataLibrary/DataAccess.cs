/*using System;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace BlazorApp.DataLibrary
{
    public class DataAccess
    {
        public static List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
        using (IDbConnection connection = new MySqlConnection()connectionString)
        {
            List<T> rows = connection.Query<T>
        }
    }
}
*/