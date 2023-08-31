//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Data.SqlClient;
//using System.Data;
//using System.Text;
//using System.Threading.Tasks;


//namespace GetDataBD
//{
//    class DataBase
//    {
//        public DataTable DatabaseTablesList(string connectionString)
//        {
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();

//                // Получение списка таблиц
//                DataTable tables = connection.GetSchema("Tables");

//                DataTable filteredTables = new DataTable();
//                filteredTables.Columns.Add("TABLE_NAME");

//                foreach (DataRow row in tables.Rows)
//                {
//                    string? catalog = row["TABLE_CATALOG"].ToString();
//                    if (catalog == "productDb")
//                    {
//                        filteredTables.Rows.Add(row["TABLE_NAME"]);
//                    }
//                }

//                return filteredTables;
//            }
//        }

//        public DataTable? LoadColumnInformation(string connectionString, string tableName)
//        {
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                try
//                {
//                    connection.Open();

//                    string query = $"SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH " +
//                                   $"FROM INFORMATION_SCHEMA.COLUMNS " +
//                                   $"WHERE TABLE_NAME = @TableName";

//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    {
//                        command.Parameters.AddWithValue("@TableName", tableName);

//                        DataTable columnInfo = new DataTable();
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            columnInfo.Load(reader);
//                            return columnInfo;
//                        }
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show($"Ошибка:\nОписание ошибки{ex.Message}");
//                }
//            }
//            return null;
//        }
//    }
//}
