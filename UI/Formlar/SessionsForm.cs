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
    public partial class SessionsForm : Form
    {
        public SessionsForm()
        {
            InitializeComponent();
        }

        SessionService sessionService = new SessionService();

        //Listeleme

        private void SessionListele()
        {
            listView1.Items.Clear();
            List<Session> sessionlist = sessionService.SessionList();
            foreach (Session session in sessionlist)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = session.SessionID.ToString();
                lvi.SubItems.Add(session.SessionTime.ToString());
                lvi.SubItems.Add(session.Duration.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void SessionsForm_Load(object sender, EventArgs e)
        {
            SessionListele();
        }

        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.SessionTime = txtTime.Text;
            session.Duration = Convert.ToInt32(txtduration.Text);
            string addresult = sessionService.AddSession(session);
            MessageBox.Show(addresult);
            SessionListele();

        }

        //Update 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.SessionID = Convert.ToInt32(txtID.Text);
            session.SessionTime = txtTime.Text;
            session.Duration= Convert.ToInt32(txtduration.Text);
            string updateresult = sessionService.UpdateSession(session);
            MessageBox.Show(updateresult);
            SessionListele();


        }
        //Delete 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string result = sessionService.DeleteSession(Convert.ToInt32(txtID.Text));
            MessageBox.Show(result);
            SessionListele();
        }

        







    }
}
