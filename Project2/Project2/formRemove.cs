using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project2
{
    public partial class formRemove : Form
    {
        public formRemove()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();

        private void brnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                
                handler.delete(CBoxName.Text);
              
                PlaneSelect planeSelect = new PlaneSelect();
                planeSelect.Show();
                this.Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string connect = @"Data Source =.; Initial Catalog=Simulator2; Integrated Security = SSPI ";
        private void formRemove_Load(object sender, EventArgs e)
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string query = @"SELECT PlaneName FROM tblPlane2";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader sqlDataReader;
                sqlDataReader = sqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("PlaneName", typeof(string));
                table.Load(sqlDataReader);
                CBoxName.ValueMember = "PlaneName";
                CBoxName.DataSource = table;
               


            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
            finally
            {
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No plane removed, going back to plane select", "Good news", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PlaneSelect plane = new PlaneSelect();
            plane.Show();
            this.Hide();
        }
    }
}
