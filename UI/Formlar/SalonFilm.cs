using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Formlar
{
    public partial class SalonFilm : Form
    {
        public SalonFilm()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        private void SalonFilm_Load(object sender, EventArgs e)
        {
            var result = db.Theaters.Select(x => new
            {
                FilmAdi = x.Movie.MovieName,
                SalonAdi =x.Saloon.SaloonName,
                SalonKapasitesi = x.Saloon.Capacity

            }).ToList();

            dataGridView1.DataSource = result;
            
            
            
        }
    }
}
