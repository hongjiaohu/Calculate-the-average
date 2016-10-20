using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_the_average
{
    public partial class frmCalculatetheaverage : Form
    {
        public frmCalculatetheaverage()
        {
            InitializeComponent();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            /**

 *

 * Name: Hongjiao Hu

 * Teacher: Mr. Hardman
 
 * Assignment #2, Program #2

 * Date Last Modified: 10/19/2016

 *

 */
            //using user inpuut number
            double Firstnume = Convert.ToDouble(txtFirstNumber.Text);
            double Secondnume = Convert.ToDouble(txtSecondNumber.Text);
            double Thirdnume = Convert.ToDouble(txtThirdNumber.Text);
            double Fourthnume = Convert.ToDouble(txtFourthNumber.Text);
            double Fifthnume = Convert.ToDouble(txtFifthNumber.Text);

            //using arithmic operator for caculation
            double average = (Firstnume + Secondnume + Thirdnume + Fourthnume + Fifthnume)/5;

            //Dispaly all caculation to the user
            lblResult.Text = string.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n\n{10,10}{11,15}",
                 "Grade 1:", Firstnume, " Grade 2:", Secondnume, "Grade 3:", Thirdnume, "Grade 4:", Fourthnume, "Grade 5:", Fifthnume, "Average:",average );




        }
    }
}
