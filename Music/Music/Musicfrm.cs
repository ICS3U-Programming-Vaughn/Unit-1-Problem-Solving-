/*
 * Created by: Vaughn Donohue
 * Created on: 18-February-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - School mascot
 * This program displays a menu bar with menu items. When you click
 * on a menu item, the label changes according to the item you clicked on.
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

namespace Music
{
    public partial class frmMusic : Form
    {
        public frmMusic()
        {
            InitializeComponent();
        }

        private void FrmMusic_Load(object sender, EventArgs e)
        {
            
        }

        private void MuseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the labels to reflect Muse
            this.lblSong.Text = "Pressure";
            this.lblAlbum.Text = "Simulation theory";
        }

        private void LblBand_Click(object sender, EventArgs e)
        {

        }

        private void RedHotChiliPeppersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
