using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE
{
    class DbHandler
    {
        static string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MunicipalityRecords;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public void InsertIntoDb(string location, string category, string description, Image image)
        {
            using(SqlConnection connection = new SqlConnection(connString))
            {
                string query = $"INSERT INTO MunicipalityRecords (location, category, description, image) VALUES ({location}, {category}, {description}, {image});";
                MessageBox.Show(query);
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
