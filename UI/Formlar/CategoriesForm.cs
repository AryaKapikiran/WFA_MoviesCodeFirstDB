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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }
        CategoryService categoryService = new CategoryService();

        //ProjectContext db = new ProjectContext();

        private void KategoriListele()
        {
           listView1.Items.Clear();
           List<Category> categoryList = categoryService.CategoryList();
            foreach (Category category in categoryList)
            {
              ListViewItem lvi = new ListViewItem();
                lvi.Text= category.CategoryID.ToString();
                lvi.SubItems.Add(category.CategoryName);
                listView1.Items.Add(lvi);
            }
        }
        //List
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        //Add
        private void button1_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = textBox1.Text;
            string addresult = categoryService.AddCategory(category);
            MessageBox.Show(addresult);
            KategoriListele();
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryID = Convert.ToInt32(textBox2.Text);
            category.CategoryName = textBox1.Text;
            string updateresult = categoryService.UpdateCategory(category);
            MessageBox.Show(updateresult);
            KategoriListele();
        }
        //Delete
        private void button3_Click(object sender, EventArgs e)
        {
            string result = categoryService.DeleteCategory(Convert.ToInt32(textBox2.Text));
            MessageBox.Show(result);
            KategoriListele();
        }
    }
}
