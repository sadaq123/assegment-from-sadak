using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbaco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sumit_Click(object sender, EventArgs e)
        {
            // Declaring variables

                string std_name, courses = " ", fullstdinfo, Extra = " ", gender = " ";
                int std_age, std_id;
                // initialing student name from input textbox
                std_name = stdname.Text;
                // validating and parsing for id_textbox  using try parse
                if (int.TryParse(stdid.Text, out std_id))
                {
                    /// MessageBox.Show("succes");
                }
                else
                {
                    MessageBox.Show("waxan aheyn lambar  lama ogolo");
                }
                // validating and parsing for  age_textbox using int.parse and conditions
                std_age = int.Parse(stdage.Text);
                if (std_age >= 18 & std_age <= 55)
                {
                    //  MessageBox.Show("succes");

                }
                else
                {
                    MessageBox.Show("so geli inta u dhaxayso 18 ilaa 35");
                    return
                    ;
                }


                // male and radio checked
                if (male.Checked)
                {
                    gender = "male ";
                }
                else if (fmale.Checked)
                {
                    gender = "female";
                }
                else
                {
                    MessageBox.Show("wa inaad dorata mid ka kid ah jinsiga");
                }

              

                // list box 
                if (courselist.SelectedIndex != -1)
                {
                    courses = courselist.SelectedItem.ToString();
                }
                else {
                    MessageBox.Show("so dooro course");
                }
                // Extra_curricular checked 
                if (extracurricular.Checked)
                {
                    Extra = " yes";


                }
                else
                {
                    Extra = "no";

                }

              





                fullstdinfo = "Name: " + std_name + " \n  ID: " + std_id + "\n  Age: " + std_age + "\n  Gender: " + gender + "\n   Extra_curricular:  " + Extra + "\n   courses:" + courses;
                resultlabel.Text = fullstdinfo;


                stdname.Focus();
          

        }

        private void clear_Click(object sender, EventArgs e)
        {
            stdname.Text = "";
            stdid.Text = "";
            stdage.Text = "";
            male.Checked = false;
            fmale.Checked = false;
            extracurricular.Checked = false;
            resultlabel.Text = "";
            courselist.ClearSelected();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }
    
}
