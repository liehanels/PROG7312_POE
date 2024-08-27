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
        public void InsertIntoDb(ReportedIssue issue)
        {
            string connString = "Server=tcp:st10085345.database.windows.net,1433;Initial Catalog=POE;Persist Security Info=False;User ID=ST10085345;Password=Password123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //clean string to prevent errors
            string location = issue.getLocation().Replace("'", "");
            string category = issue.getCategory().Replace("'", "");
            string description = issue.getDescription().Replace("'", "");
            //build the query
            string query = $"INSERT into reported_issues " +
                $"(location, category, description, image) " +
                $"VALUES ('{location}', '{category}', '{description}', '{issue.getAttachedFile()}')";
            
            //debugging to view query
            //MessageBox.Show(query);
            
            //using the connection string
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //new sql command
                SqlCommand comm = new SqlCommand(query, conn);
                //tries to open the connection and write to db
                try
                {
                    conn.Open();
                    int rowsAffected = comm.ExecuteNonQuery();
                    //if row is added
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record added!");
                    }
                    //if row is not added
                    else
                    {
                        MessageBox.Show("No record added...");
                    }
                }
                //if connection cannot be opened
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    MessageBox.Show("No record added...");
                }
            }
        }
    }
}
