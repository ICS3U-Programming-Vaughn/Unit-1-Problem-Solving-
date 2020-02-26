/*
 * Created by: Vaughn Donohue
 * Created on: 26-February-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Name of Program
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVaughn
{
    public partial class frmPerArea : Form
    {
        public frmPerArea()
        {
            InitializeComponent();
            // this will hide the answer 
            this.lblPerimeter.Hide();

            //this will show the answer
            this.lblPerimeter.Show();

            // this will hide the answer
            this.lblArea.Hide();

            //this will show the answer
            this.lblArea.Show();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            //this will close the program
            this.Close();
        }

        private void LblPerAnswer_Click(object sender, EventArgs e)
        {
            
        }

        private void LblAreaAnswer_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare variable
            double length, width, area, perimeter;
            
            // convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            // calculate the area and perimeter
            perimeter = 2 * length + 2 * width;
            area = length * width;
            
            // insert the area and the perimeter into their labels
            this.lblAreaAnswer.Text = Convert.ToString(area) + "squared meters";
            this.lblPerAnswer.Text = Convert.ToString(perimeter) + "squared meters";


            //display the perimeter and area labels with their answers
            this.lblPerAnswer.Show();
            this.lblAreaAnswer.Show();

        }
    }
}
