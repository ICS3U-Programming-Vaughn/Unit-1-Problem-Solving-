namespace Music
{
    partial class frmMusic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.mniBands = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMuse = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRedHotChiliPeppers = new System.Windows.Forms.ToolStripMenuItem();
            this.mniArcticMonkeys = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBillyTalent = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbBands = new System.Windows.Forms.GroupBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.mnuProgram.SuspendLayout();
            this.grbBands.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniBands});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(800, 24);
            this.mnuProgram.TabIndex = 0;
            this.mnuProgram.Text = "menuStrip1";
            // 
            // mniBands
            // 
            this.mniBands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMuse,
            this.mniRedHotChiliPeppers,
            this.mniArcticMonkeys,
            this.mniBillyTalent});
            this.mniBands.Name = "mniBands";
            this.mniBands.Size = new System.Drawing.Size(51, 20);
            this.mniBands.Text = "Bands";
            // 
            // mniMuse
            // 
            this.mniMuse.Name = "mniMuse";
            this.mniMuse.Size = new System.Drawing.Size(189, 22);
            this.mniMuse.Text = "Muse";
            this.mniMuse.Click += new System.EventHandler(this.MuseToolStripMenuItem_Click);
            // 
            // mniRedHotChiliPeppers
            // 
            this.mniRedHotChiliPeppers.Name = "mniRedHotChiliPeppers";
            this.mniRedHotChiliPeppers.Size = new System.Drawing.Size(189, 22);
            this.mniRedHotChiliPeppers.Text = "Red Hot Chili Peppers";
            this.mniRedHotChiliPeppers.Click += new System.EventHandler(this.RedHotChiliPeppersToolStripMenuItem_Click);
            // 
            // mniArcticMonkeys
            // 
            this.mniArcticMonkeys.Name = "mniArcticMonkeys";
            this.mniArcticMonkeys.Size = new System.Drawing.Size(189, 22);
            this.mniArcticMonkeys.Text = "Arctic Monkeys";
            this.mniArcticMonkeys.Click += new System.EventHandler(this.MniArcticMonkeys_Click);
            // 
            // mniBillyTalent
            // 
            this.mniBillyTalent.Name = "mniBillyTalent";
            this.mniBillyTalent.Size = new System.Drawing.Size(189, 22);
            this.mniBillyTalent.Text = "Billy Talent";
            this.mniBillyTalent.Click += new System.EventHandler(this.MniBillyTalent_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grbBands
            // 
            this.grbBands.Controls.Add(this.lblAlbum);
            this.grbBands.Controls.Add(this.lblSong);
            this.grbBands.Location = new System.Drawing.Point(165, 94);
            this.grbBands.Name = "grbBands";
            this.grbBands.Size = new System.Drawing.Size(383, 247);
            this.grbBands.TabIndex = 2;
            this.grbBands.TabStop = false;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(9, 70);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(90, 31);
            this.lblAlbum.TabIndex = 1;
            this.lblAlbum.Text = "Album";
            this.lblAlbum.Click += new System.EventHandler(this.LblBand_Click);
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.Location = new System.Drawing.Point(6, 16);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(77, 31);
            this.lblSong.TabIndex = 0;
            this.lblSong.Text = "Song";
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbBands);
            this.Controls.Add(this.mnuProgram);
            this.MainMenuStrip = this.mnuProgram;
            this.Name = "frmMusic";
            this.Text = "Music By Vaughn D.";
            this.Load += new System.EventHandler(this.FrmMusic_Load);
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.grbBands.ResumeLayout(false);
            this.grbBands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniBands;
        private System.Windows.Forms.ToolStripMenuItem mniMuse;
        private System.Windows.Forms.ToolStripMenuItem mniRedHotChiliPeppers;
        private System.Windows.Forms.GroupBox grbBands;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.ToolStripMenuItem mniArcticMonkeys;
        private System.Windows.Forms.ToolStripMenuItem mniBillyTalent;
    }
}

