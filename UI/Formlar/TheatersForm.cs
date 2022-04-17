using BLL.Service;
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
    public partial class TheatersForm : Form
    {
        public TheatersForm()
        {
            InitializeComponent();
        }
        TheaterService theaterService = new TheaterService();
        //Listeleme

        private void TheaterList()
        {
            listView1.Items.Clear();
            List<Theater> theaterlist = theaterService.TheaterListele();

            foreach (Theater theater in theaterlist)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = theater.TheaterID.ToString();
                lvi.SubItems.Add(theater.MovieID.ToString());
                lvi.SubItems.Add(theater.SessionID.ToString());
                lvi.SubItems.Add(theater.WeekID.ToString());
                lvi.SubItems.Add(theater.SaloonID.ToString());
                listView1.Items.Add(lvi);


            }
        }


        private void TheatersForm_Load(object sender, EventArgs e)
        {
            TheaterList();
        }
        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Theater theater = new Theater();
            theater.MovieID= Convert.ToInt32(txtMovie.Text);
            theater.SessionID= Convert.ToInt32(txtSessionID.Text);
            theater.WeekID= Convert.ToInt32(txtWeekID.Text);
            theater.SaloonID= Convert.ToInt32(txtSaloonID.Text);
            string addresult = theaterService.AddTheater(theater);
            MessageBox.Show(addresult);
            TheaterList();

        }
        //Update 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Theater theater= new Theater();
            theater.TheaterID = Convert.ToInt32(txtTheaterID.Text);
            theater.MovieID = Convert.ToInt32(txtMovie.Text);
            theater.SessionID = Convert.ToInt32(txtSessionID.Text);
            theater.WeekID = Convert.ToInt32(txtWeekID.Text);
            theater.SaloonID = Convert.ToInt32(txtSaloonID.Text);
            string updateresult = theaterService.UpdateTheater(theater);
            MessageBox.Show(updateresult);
            TheaterList();

        }
       //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string result = theaterService.DeleteTheater(Convert.ToInt32(txtTheaterID.Text));
            MessageBox.Show(result);
            TheaterList();
        }

       


    }
}
