using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRJellyBelly
{
    public partial class CategoryCount : Form
    {
        //Connection to our datasource 
        MyJellyBellyDb db = new MyJellyBellyDb();
        public CategoryCount()
        {
            InitializeComponent();

        }

        private void CategoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Close the Category form
            Close();
        }

        //Loads the Categories Modal
        private void CategoryCount_Load(object sender, EventArgs e)
        {
            //Adds two columns to the CategoryListView box that will record the Category and Count for the Jelly Beans.
            CategoryListView.Columns.Add("Category");
            CategoryListView.Columns.Add("Count");

            //Method syntax to group all categories together. Descend by total
            var catList = db.JBSet.GroupBy(jb => jb.category).Select(jb => new CategoryCount
            {
                Category = jb.Key,
                Total = jb.Count()
            }).OrderByDescending(jb => jb.Total);

            //execute the query
            foreach (var cat in catList)
            {
                string [] catTotal = {cat.Category, cat.Total.ToString()};
                ListViewItem lvi = new ListViewItem(catTotal);
                CategoryListView.Items.Add(lvi);
            }

            //Format how the data is displayed in the form
            CategoryListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            CategoryListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);

        }
    }
}
