using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;


namespace DataBaseLibrary
{
    public class DataBase
    {
        public string serverName = "";
        public string nameDB = "";
        public string loginDB = "";
        public string passwordDB = "";
        public string connectionString = "";

        public DataTable DatabaseTablesList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString =
                        $"Data Source={serverName};Initial Catalog={nameDB};User id={loginDB};Password={passwordDB};";
                    connection.Open();

                    // Получение списка таблиц
                    DataTable tables = connection.GetSchema("Tables");

                    DataTable filteredTables = new DataTable();
                    filteredTables.Columns.Add("TABLE_NAME");

                    foreach (DataRow row in tables.Rows)
                    {
                        string catalog = row["TABLE_CATALOG"].ToString();
                        if (catalog == "productDb")
                        {
                            filteredTables.Rows.Add(row["TABLE_NAME"]);
                        }
                    }

                    return filteredTables;
                }
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public DataTable LoadColumnInformation(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.ConnectionString =
                        $"Data Source={serverName};Initial Catalog={nameDB};User id={loginDB};Password={passwordDB};";
                    connection.Open();

                    string query = $"SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH " +
                                   $"FROM INFORMATION_SCHEMA.COLUMNS " +
                                   $"WHERE TABLE_NAME = @TableName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableName", tableName);

                        DataTable columnInfo = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            columnInfo.Load(reader);
                            return columnInfo;
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
            
        }
    }
}
