namespace UI
{
    partial class Form1
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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSaloonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDTheaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmSaarSalonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieToolStripMenuItem,
            this.addCategoryToolStripMenuItem,
            this.addSaloonToolStripMenuItem,
            this.addSessionToolStripMenuItem,
            this.addWeekToolStripMenuItem,
            this.cRUDTheaterToolStripMenuItem,
            this.filmSaarSalonToolStripMenuItem,
            this.salonFilmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1426, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.addMovieToolStripMenuItem.Text = "CRUDMovie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.addCategoryToolStripMenuItem.Text = "CRUDCategory";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // addSaloonToolStripMenuItem
            // 
            this.addSaloonToolStripMenuItem.Name = "addSaloonToolStripMenuItem";
            this.addSaloonToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.addSaloonToolStripMenuItem.Text = "CRUDSaloon";
            this.addSaloonToolStripMenuItem.Click += new System.EventHandler(this.addSaloonToolStripMenuItem_Click);
            // 
            // addSessionToolStripMenuItem
            // 
            this.addSessionToolStripMenuItem.Name = "addSessionToolStripMenuItem";
            this.addSessionToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.addSessionToolStripMenuItem.Text = "CRUDSession";
            this.addSessionToolStripMenuItem.Click += new System.EventHandler(this.addSessionToolStripMenuItem_Click);
            // 
            // addWeekToolStripMenuItem
            // 
            this.addWeekToolStripMenuItem.Name = "addWeekToolStripMenuItem";
            this.addWeekToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.addWeekToolStripMenuItem.Text = "CRUDWeek";
            this.addWeekToolStripMenuItem.Click += new System.EventHandler(this.addWeekToolStripMenuItem_Click);
            // 
            // cRUDTheaterToolStripMenuItem
            // 
            this.cRUDTheaterToolStripMenuItem.Name = "cRUDTheaterToolStripMenuItem";
            this.cRUDTheaterToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.cRUDTheaterToolStripMenuItem.Text = "CRUDTheater";
            this.cRUDTheaterToolStripMenuItem.Click += new System.EventHandler(this.cRUDTheaterToolStripMenuItem_Click);
            // 
            // filmSaarSalonToolStripMenuItem
            // 
            this.filmSaarSalonToolStripMenuItem.Name = "filmSaarSalonToolStripMenuItem";
            this.filmSaarSalonToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.filmSaarSalonToolStripMenuItem.Text = "FilmSaatSalon";
            this.filmSaarSalonToolStripMenuItem.Click += new System.EventHandler(this.filmSaarSalonToolStripMenuItem_Click);
            // 
            // salonFilmToolStripMenuItem
            // 
            this.salonFilmToolStripMenuItem.Name = "salonFilmToolStripMenuItem";
            this.salonFilmToolStripMenuItem.Size = new System.Drawing.Size(105, 32);
            this.salonFilmToolStripMenuItem.Text = "SalonFilm";
            this.salonFilmToolStripMenuItem.Click += new System.EventHandler(this.salonFilmToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 836);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSaloonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDTheaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmSaarSalonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonFilmToolStripMenuItem;
    }
}

