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
    public partial class SearchJellyBeans : Form
    {
       
        MyJellyBellyDb db = new MyJellyBellyDb();

        public SearchJellyBeans()
        {
            InitializeComponent();

            //Selects all items from the MyJellyBellyDB and displays them in the modal.
            var jbList = from jbItem in db.JBSet
                         select jbItem;


            DgvJellyBellies.DataSource = jbList.ToList();

            //DgvJellyBellies.DataSource = jbList;


        }

        //Clear the search text and clear filters. It will then show the unfiltered data
        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            TxtJellySearch.Clear();
            CboFilterByCategory.SelectedIndex = -1;

            var jbList = from jb in db.JBSet
                         select jb;

            //execute query
            DgvJellyBellies.DataSource = jbList.ToList();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Add a close button
            Close();
        }

        //The result set will be filtered when the search text box receives the users input
        private void TxtJellySearch_TextChanged(object sender, EventArgs e)
        {

            if(CboFilterByCategory.SelectedIndex > -1)
            {
                var jbSearch = from jb in db.JBSet
                                              where jb.jellyBellyFlavor.Contains(TxtJellySearch.Text) &&
                                              jb.category == CboFilterByCategory.SelectedItem.ToString()
                                              select jb;
                                              

                //Assign query result to datasource
                DgvJellyBellies.DataSource = jbSearch.ToList();
            }
            else
            {
                var jbSearch = from jb in db.JBSet
                               where jb.jellyBellyFlavor.Contains(TxtJellySearch.Text) 
                               select jb;
            }
            
        }

        //When the user selects a category from the list, the result set will filter to the users input
        private void CboFilterByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //The search box will clear if the user selects a category filter after filling the search field
            TxtJellySearch.Clear();

            if (CboFilterByCategory.SelectedIndex > -1)
            {

                var catFilter = from jb in db.JBSet
                                where jb.category == CboFilterByCategory.SelectedItem.ToString()
                                select jb;

                //execute query
                DgvJellyBellies.DataSource = catFilter.ToList();
            }
        }

        private void SearchJellyBeans_Load(object sender, EventArgs e)
        {
            
            List<JellyBelly> JellyList = (from jellyBelly in db.JBSet select jellyBelly).ToList();

            AutoSizeColumns();

            //Call the DataGridView and assign it the JellyList we just populated
            DgvJellyBellies.DataSource=JellyList;

            //Announcement Video Notes
            //Query syntax to populate the datagridview
            var jbList = from jb in db.JBSet
                            select jb;

            //query to populate the combo box
            var CatList = from jb in db.JBSet
                          group jb by jb.category
                          into singleCategory
                          select singleCategory;

            //execute previous queries with a foreach loop
            //query syntax
            foreach(var cat in CatList)
            {
                CboFilterByCategory.Items.Add(cat.Key);
            }

            //execute queries
            DgvJellyBellies.DataSource = jbList.ToList();

            //This will hide the Id column because we dont need it in the result set
            DgvJellyBellies.Columns["JellyBellyId"].Visible = false;
        }

        //This should load the data grid view to fill the whole modal
        private void AutoSizeColumns()
        {
            int columns = DgvJellyBellies.Columns.Count;

            for (int i = 0; i < columns; i++)
            {
                DgvJellyBellies.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void DgvJellyBellies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }
    }
}
