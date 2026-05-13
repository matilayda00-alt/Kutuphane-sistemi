using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace KutuphaneTakipSistemi
{
    public static class DatabaseHelper
    {
        private static string connectionString = @"Server=.\SQLEXPRESS;Database=KutuphaneDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    DataTable dt = new DataTable();
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        return dt;
                    }
                    catch (SqlException sqlEx)
                    {
                        try
                        {
                            if (conn.State != ConnectionState.Open) conn.Open();
                            using (var infoCmd = new SqlCommand("SELECT DB_NAME()", conn))
                            {
                                var dbName = infoCmd.ExecuteScalar()?.ToString() ?? "<unknown>";

                                using (var listCmd = new SqlCommand("SELECT TABLE_SCHEMA + '.' + TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_SCHEMA, TABLE_NAME", conn))
                                {
                                    using (var reader = listCmd.ExecuteReader())
                                    {
                                        var tables = new System.Text.StringBuilder();
                                        while (reader.Read())
                                        {
                                            if (tables.Length > 0) tables.Append(',');
                                            tables.Append(reader.GetString(0));
                                        }

                                        throw new Exception($"ExecuteQuery failed. SQL error: {sqlEx.Message}. Database: {dbName}. Available tables: {tables}. Query: {query}", sqlEx);
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            throw new Exception($"ExecuteQuery failed. SQL error: {sqlEx.Message}. Query: {query}", sqlEx);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"ExecuteQuery failed for query: '{query}'. See inner exception for details.", ex);
                    }
                }
            }
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"ExecuteNonQuery failed for query: '{query}'. See inner exception for details.", ex);
                    }
                }
            }
        }
    }
}
