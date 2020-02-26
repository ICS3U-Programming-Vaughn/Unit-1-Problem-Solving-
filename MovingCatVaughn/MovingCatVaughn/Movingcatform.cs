/*
 * Created by: Vaughn D.
 * Created on: 19-February-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Moving Cat
 * This program displays a menu strip with a drop-down menu of 4 menu items. When I click on each menu item, 
 * the picture in the picture box changes accordingly. 
 * When I click on Exit the program closes.
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

namespace MovingCatVaughn
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void MniCat2_Click(object sender, EventArgs e)
        {
            // change the picture to cat 2
            this.picGibson.Image = Properties.Resources.cat2;
            
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MniCat1_Click(object sender, EventArgs e)
        {
            this.picGibson.Image = Properties.Resources.cat1;
        }

        private void FenderTelecasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picGibson.Image = Properties.Resources.RED_TELE_f_9447b3ac_8505_497c_8474_9358aa5bf07b;
        }

        private void MniGibson_Click(object sender, EventArgs e)
        {
            this.picGibson.Image = Properties.Resources.Gibson_SG_Standard_61_Maestro_Vibrola_059_VC_01;
        }
    }
}
