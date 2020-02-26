/*
 * Created by: Vaughn Donohue
 * Created on: 26-February-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Name of Program
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

namespace CircumfrenceVaughn
{
    public partial class frmCircumfrence : Form
    {
        public frmCircumfrence()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // when clicked program is closed
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //declare the local variable
            double circumfrence, radius;

            //get the radius from the text box
            radius = double.Parse(txtInput.Text);
            
            
            //calculate the circumfrence
            circumfrence = 2 * Math.PI * radius;

            // insert circumfence and raius to their respective labels
            this.lblCircumferenceAnswer.Text = Convert.ToString(circumfrence) + "cm";




        }

        private void LblCircumferenceAnswer_Click(object sender, EventArgs e)
        {
            //this will hide the code
            this.lblCircumferenceAnswer.Hide();

            // this will show the code
            this.lblCircumferenceAnswer.Show();
        }
    }
}
