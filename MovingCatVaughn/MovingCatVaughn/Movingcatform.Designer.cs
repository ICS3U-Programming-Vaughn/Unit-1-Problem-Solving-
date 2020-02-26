namespace MovingCatVaughn
{
    partial class frmMovingCat
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.catToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.guitarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFender = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGibson = new System.Windows.Forms.ToolStripMenuItem();
            this.picGibson = new System.Windows.Forms.PictureBox();
            this.mnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGibson)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.catToolStripMenuItem,
            this.guitarsToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(800, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // catToolStripMenuItem
            // 
            this.catToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.catToolStripMenuItem.Name = "catToolStripMenuItem";
            this.catToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.catToolStripMenuItem.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(101, 22);
            this.mniCat1.Text = "Cat 1";
            this.mniCat1.Click += new System.EventHandler(this.MniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(101, 22);
            this.mniCat2.Text = "Cat 2";
            this.mniCat2.Click += new System.EventHandler(this.MniCat2_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(93, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // guitarsToolStripMenuItem
            // 
            this.guitarsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFender,
            this.mniGibson});
            this.guitarsToolStripMenuItem.Name = "guitarsToolStripMenuItem";
            this.guitarsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.guitarsToolStripMenuItem.Text = "Guitars";
            // 
            // mniFender
            // 
            this.mniFender.Name = "mniFender";
            this.mniFender.Size = new System.Drawing.Size(180, 22);
            this.mniFender.Text = "Fender Telecaster";
            this.mniFender.Click += new System.EventHandler(this.FenderTelecasterToolStripMenuItem_Click);
            // 
            // mniGibson
            // 
            this.mniGibson.Name = "mniGibson";
            this.mniGibson.Size = new System.Drawing.Size(180, 22);
            this.mniGibson.Text = "Gibson SG";
            this.mniGibson.Click += new System.EventHandler(this.MniGibson_Click);
            // 
            // picGibson
            // 
            this.picGibson.Image = global::MovingCatVaughn.Properties.Resources.Gibson_SG_Standard_61_Maestro_Vibrola_059_VC_01;
            this.picGibson.Location = new System.Drawing.Point(141, 46);
            this.picGibson.Name = "picGibson";
            this.picGibson.Size = new System.Drawing.Size(502, 392);
            this.picGibson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGibson.TabIndex = 1;
            this.picGibson.TabStop = false;
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picGibson);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat by Vaughn";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGibson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem catToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.PictureBox picGibson;
        private System.Windows.Forms.ToolStripMenuItem guitarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniFender;
        private System.Windows.Forms.ToolStripMenuItem mniGibson;
    }
}

