using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project2
{
    class DataHandler
    {
        public DataHandler() { }
        //Connect to database
        string connect = @"Data Source =.; Initial Catalog=Simulator2; Integrated Security = SSPI ";
        SqlConnection connection;
        SqlCommand command;
        
        //Insert function
        public void insert( string planeName, int healthPoints, int speed, int weight, int damage, int inventory, int feulLevel)
        {
            string query = @"INSERT INTO tblPlane2 VALUES('"+planeName+ "','" + healthPoints + "','" + speed + "','" + weight + "','" + damage + "','" + inventory + "','" + feulLevel + "')";
            connection = new SqlConnection(connect);
            connection.Open();
            command = new SqlCommand(query, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("New plane have been added","Good news", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                
            }
            finally
            {
                connection.Close();
            }
        }

        //delete function
        public void delete(string planeName)
        {
            string query = @"DELETE FROM tblPlane2 WHERE PlaneName = ('" + planeName + "')";
            connection = new SqlConnection(connect);
            connection.Open();
            command = new SqlCommand(query, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show(planeName + " have been removed","Bad news", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
