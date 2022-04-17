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
    public partial class FilmSaatSalon : Form
    {
        public FilmSaatSalon()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void FilmSaatSalon_Load(object sender, EventArgs e)
        {
            var result = db.Theaters.Select(x => new
            {
                FilmAdi = x.Movie.MovieName,
                Saat = x.Session.SessionTime,
                SalonAdi= x.Saloon.SaloonName

            }).ToList();

            dataGridView1.DataSource = result;
            
            
            
        }
    }
}
