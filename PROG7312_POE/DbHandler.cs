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

            string location = issue.getLocation().Replace("'", "");
            string category = issue.getCategory().Replace("'", "");
            string description = issue.getDescription().Replace("'", "");

            string query = $"INSERT into reported_issues " +
                $"(location, category, description, image) " +
                $"VALUES ('{location}', '{category}', '{description}', '{issue.getAttachedFile()}')";

            MessageBox.Show(query);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    int rowsAffected = comm.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record added!");
                    }
                    else
                    {
                        MessageBox.Show("No record added...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    MessageBox.Show("No record added...");
                }
            }
        }
    }
}
