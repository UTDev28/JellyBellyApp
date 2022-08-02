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


    public partial class LandingForm : Form
    {
        //Establish connection to the database
        MyJellyBellyDb db = new MyJellyBellyDb();

        public LandingForm()
        {
            InitializeComponent();

            //linq query for loading jelly beans in 
            //var jbList = from jbItem in db.JBSet
            //             select jbItem;

            //DgvJellyBellies.Datasource = jbList.ToList();

            
        }

        private void BtnShowJBFlavors_Click(object sender, EventArgs e)
        {
            //When the user selects "show jelly beans", it will display the SearchJellyBeans class as a model
            SearchJellyBeans searchJellyBeans = new SearchJellyBeans(); 
            searchJellyBeans.ShowDialog();
        }

        private void BtnShowCategories_Click(object sender, EventArgs e)
        {
            //Opens the category class as a model when the user selects the button. 
            CategoryCount categoryCount = new CategoryCount();
            categoryCount.ShowDialog();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
