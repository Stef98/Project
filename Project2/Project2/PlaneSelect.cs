using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SortOrder = System.Windows.Forms.SortOrder;

namespace Project2
{
    public partial class PlaneSelect : Form
    {
        public static string ValueName = " ";
        public static string ValueHealth = " ";
        public static string ValueSpeed = " ";
        public static string ValueWeight = " ";
        public static string ValueDamage = " ";
        public static string ValueInventory = " ";
        public static string ValueFuel = " ";

        public PlaneSelect()
        {
            InitializeComponent();
        }
        string connect = @"Data Source =.; Initial Catalog=Simulator2; Integrated Security = SSPI ";


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {

            if (txtPlaneName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Pleas select a plane");
            }
            else
            {
                ValueName = txtPlaneName.Text;
                ValueHealth = txtHealth.Text;
                ValueSpeed = txtSpeed.Text;
                ValueWeight = txtWeight.Text;
                ValueDamage = txtDamage.Text;
                ValueInventory = txtInventory.Text;
                ValueFuel = txtFuel.Text;
                FormMap formMap = new FormMap();
                formMap.Show();
                this.Hide();
            }

            }
            catch (Exception wxc)
            {
                MessageBox.Show(wxc.Message);
                
            }
        }


        private void PlaneSelect_Load(object sender, EventArgs e)
        {
            //lblBegin.Hide();

            SqlConnection connection = new SqlConnection(connect);
            string select = @"SELECT PlaneName,HealthPoints,Speed,Weight,Damage,Inventory,FeulLevel FROM tblPlane2";
            DataTable table = new DataTable();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select, connection);

            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;

       
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        int indexRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtPlaneName.Text = row.Cells[0].Value.ToString();
            txtHealth.Text = row.Cells[1].Value.ToString();
            txtSpeed.Text = row.Cells[2].Value.ToString();
            txtWeight.Text = row.Cells[3].Value.ToString();
            txtDamage.Text = row.Cells[4].Value.ToString();
            txtInventory.Text = row.Cells[5].Value.ToString();
            txtFuel.Text = row.Cells[6].Value.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPlane addPlane = new AddPlane();
            addPlane.Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            formRemove formRemove = new formRemove();
            formRemove.Show();
            this.Hide();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            ListSortDirection direction;
            if (oldColumn!=null)
            {
                if (oldColumn == newColumn && dataGridView1.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;

            }
            dataGridView1.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
    }
}
