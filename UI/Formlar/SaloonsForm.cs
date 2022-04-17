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
    public partial class SaloonsForm : Form
    {
        public SaloonsForm()
        {
            InitializeComponent();
        }

        SaloonService saloonService = new SaloonService();
        
        //List 
        private void SalonListele()
        {
            listView1.Items.Clear();
            List<Saloon> saloonlist = saloonService.SaloonList();

            foreach (Saloon saloon in saloonlist)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = saloon.SaloonID.ToString();
                lvi.SubItems.Add(saloon.SaloonName);
                lvi.SubItems.Add(saloon.Capacity.ToString());
                listView1.Items.Add(lvi);

            }
        }


        private void SaloonsForm_Load(object sender, EventArgs e)
        {
            SalonListele();
        }
          //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Saloon saloon = new Saloon();
            saloon.SaloonName = txtname.Text;
            saloon.Capacity = Convert.ToInt32(txtcapacity.Text);
            string salonekle = saloonService.AddSaloon(saloon);
            MessageBox.Show(salonekle);
            SalonListele();

        }
           //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Saloon saloon = new Saloon();
            saloon.SaloonID = Convert.ToInt32(txtID.Text);
            saloon.SaloonName= txtname.Text;
            saloon.Capacity= Convert.ToInt32(txtcapacity.Text);
            string update = saloonService.UpdateSaloon(saloon);
            MessageBox.Show(update);
            SalonListele();
        }
        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteresult = saloonService.DeleteSaloon(Convert.ToInt32(txtID.Text));
            MessageBox.Show(deleteresult);
            SalonListele();
        }
    }
}
