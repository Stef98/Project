using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class AddPlane : Form
    {
        public AddPlane()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        DataHandler handler = new DataHandler();
        private void btnBack_Click(object sender, EventArgs e)
        {
            PlaneSelect planeSelect = new PlaneSelect();
            planeSelect.Show();
            this.Hide();
        }

        private void AddPlane_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Pleas enter a name!");
            }

            else if (int.Parse(txtSpeed.Text)>10)
            {
                MessageBox.Show("Speed can only go up to 10");
            }
            else
            {
                handler.insert(txtName.Text, int.Parse(txtHealth2.Text), int.Parse(txtSpeed.Text), int.Parse(txtWeight.Text), int.Parse(txtDamage.Text), int.Parse(txtInventory.Text), int.Parse(txtFuel.Text));
                PlaneSelect planeSelect = new PlaneSelect();
                planeSelect.Show();
                this.Hide();

            }


            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }

        }

   

        
    }
}
