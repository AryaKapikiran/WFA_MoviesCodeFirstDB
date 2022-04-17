using BLL.Service;
using DataAccess.Context;
using DataAccess.Entity;
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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }
        MovieService movieService = new MovieService();
        ProjectContext db = new ProjectContext();

        //List
        private void MovieListele()
        {
            listView1.Items.Clear();
            List<Movie> movielist = movieService.MovieList();
            foreach (Movie movie in movielist )
            {
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = movie.MovieID.ToString();
                lvi.SubItems.Add(movie.MovieName);
               
                //Todo
               // lvi.SubItems.Add(movie.CategoryName);
                
                listView1.Items.Add(lvi);
            }
        }
        private void MoviesForm_Load(object sender, EventArgs e)
        {
            MovieListele();

            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DataSource = db.Categories.ToList();
        }
        //Add
        private void button1_Click(object sender, EventArgs e)
        {
           
            Movie movie = new Movie();
            
            movie.MovieName = textBox2.Text;
            
            //Todo // movie.Categories= (int)comboBox1.SelectedValue;
            string result= movieService.AddMovie(movie);
            MessageBox.Show(result);
            MovieListele();
        }
        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieID = Convert.ToInt32(textBox1.Text);
            movie.MovieName = textBox2.Text;
            string updateresult = movieService.UpdateMovie(movie);
            MessageBox.Show(updateresult);
            MovieListele();

        }

        //Delete
        private void button3_Click(object sender, EventArgs e)
        {
            string deleteresult = movieService.DeleteMovie(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(deleteresult);
            MovieListele();
        }
    }
}
