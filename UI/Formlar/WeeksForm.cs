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
    public partial class WeeksForm : Form
    {
        public WeeksForm()
        {
            InitializeComponent();
        }

        WeekService weekService = new WeekService();

        //List 

        private void WeekListele()
        {
            listView1.Items.Clear();
            List<Week> weeklist = weekService.WeekList();
            foreach(Week week in weeklist)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text= week.WeekID.ToString();
                lvi.SubItems.Add(week.WeekofTheYear.ToString());
                lvi.SubItems.Add(week.FirstDay.ToShortDateString());
                lvi.SubItems.Add(week.LastDay.ToShortDateString());
                listView1.Items.Add(lvi);
            }
        }
        

        private void WeeksForm_Load(object sender, EventArgs e)
        {
            WeekListele();
        }
        
        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Week week = new Week();
            week.WeekofTheYear = Convert.ToInt32(txtWeekofYear.Text);
            week.FirstDay = dtfirstday.Value;
            week.LastDay= dtLastDay.Value;
            string result = weekService.AddWeek(week);
            MessageBox.Show(result);
            WeekListele();
        }
          //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Week week = new Week();
            week.WeekID = Convert.ToInt32(txtWeekID.Text);
            week.WeekofTheYear = Convert.ToInt32(txtWeekofYear.Text);
            week.FirstDay=dtfirstday.Value;
            week.LastDay=dtLastDay.Value;
            string updatedresult = weekService.UpdateWeek(week);
            MessageBox.Show(updatedresult);
            WeekListele();
        }
 
        
        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string result = weekService.DeleteWeek(Convert.ToInt32(txtWeekID.Text));
            MessageBox.Show(result);
            WeekListele();
        }

        












    }
}
