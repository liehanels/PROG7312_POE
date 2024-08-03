﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    class DbHandler
    {
        static string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MunicipalityRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;";
        public void InsertIntoDb(string location, string category, string description, Image image)
        {
            using(SqlConnection connection = new SqlConnection(connString))
            {
                string query = $"INSERT INTO MunicipalityRecords VALUES ({location}, {category}, {description}, {image});";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }
            }
        }
    }
}