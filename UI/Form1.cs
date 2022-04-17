using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Formlar;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 60;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.WindowState = FormWindowState.Maximized;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MoviesForm());
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CategoriesForm());
        }

        private void addSaloonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SaloonsForm());
        }

        private void addSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SessionsForm());
        }

        private void addWeekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new WeeksForm());
        }

        private void cRUDTheaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new TheatersForm());
        }

        private void filmSaarSalonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new FilmSaatSalon());
        }

        private void salonFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new SalonFilm());
        }
    }
}
