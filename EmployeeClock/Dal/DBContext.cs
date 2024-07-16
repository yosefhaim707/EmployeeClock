using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace EmployeeClock.Dal
{
    public class DBContext
    {
        private readonly string _connectionString;


        public DBContext()
        {
           
            _connectionString = GetConnectionString();
        }
        public DataTable MakeSelectQuery(string queryStr)
        {
            DataTable output = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryStr, connection))
                {
                    try
                    { 
                        connection.Open();
                        
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(output);
                            } 
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Error occured:" + e.Message);
                    }
                }
            }
            return output;
        }
        public int MakeNonQuery(string queryStr)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryStr, connection))
                {
                    try
                    {
                        connection.Open();
                        rowAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Error occured:" + e.Message);
                    }
                }
            }
            return rowAffected;
        }
        private string GetConnectionString()
        {
            // SET SECRETS.JSON TO COPY ALWAYS AFTER ADDING!!
            IConfiguration builder = new ConfigurationBuilder()
                .AddJsonFile("secrets.json", optional: true) // Add secrets.json
                .Build();
            // Read a value from the configuration
            string connString = builder["ConnectionString"];
            if (connString == null)
            {
                   throw new Exception("Connection string not found in secrets.json");
            }
            return connString;
        }
    }
}
