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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            if (FormMap.success == false)
            {
                lblPlaneName.Text = FormMap.jetName;
                lblHealth.Text = FormMap.jetHealth.ToString();
                lblStatus.Text = FormMap.status;
                lblFuel.Text = 0.ToString();
                lblStatus.ForeColor = Color.Red;
                lblEnemyhealth.Text = FormMap.oldEnemyHealth.ToString();
            }
            else if (FormMap.success == true)
            {
                lblPlaneName.Text = PlaneSelect.ValueName;
                lblHealth.Text = FormMap.newjetHealth.ToString();
                lblStatus.Text = FormMap.status;
                lblEnemyhealth.Text = FormMap.newEnemyHealth.ToString();
                lblStatus.ForeColor = Color.Green;

                if (int.Parse(lblEnemyhealth.Text) <=0)
                {
                    lblCondition.Text = "Destroyed";
                }
                else if (int.Parse(lblEnemyhealth.Text) < 20)
                {
                    lblCondition.Text = "Decent Damge";
                }
                else
                {
                    lblCondition.Text = "Weak Damage";
                }
                //lblFuel.Text = 

                if (int.Parse(lblHealth.Text) < 10) 
                {
                    lblPlaneCondition.Text = "Major repairs required";
                }
                else
                {
                    lblPlaneCondition.Text = "Minor repairs required"; 
                }
            }
            

        }
    }
}
