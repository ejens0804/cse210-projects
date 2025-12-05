using System;
using MySqlConnector;

namespace FinalProject
{
    public static class DatabaseConfig
    {
        // Attributes/Member Variables
        // Database Connection Details
        private const string Host = "sql3.freesqldatabase.com";
        private const string Database = "sql3810215";
        private const string User = "sql3810215";
        private const string Password = "nzt86243b3";
        private const string Port = "3306";


        // Build the connection string
        public static string ConnectionString => 
            $"Server={Host};Port={Port};Database={Database};User ID={User};Password={Password};";


        // Test method to verify connection works
        public static bool TestConnection()
        {
            try
            {
                using (var conn = new MySqlConnector.MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    Console.WriteLine("✓ Database connection successful!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Database connection failed: {ex.Message}");
                return false;
            }
        }
    }
}