using System;
using System.Data.Entity;
using System.Linq;

namespace KRJellyBelly
{
    public class MyJellyBellyDb : DbContext
    {
        // Your context has been configured to use a 'MyJellyBellyDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KRJellyBelly.MyJellyBellyDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyJellyBellyDb' 
        // connection string in the application configuration file.
        public MyJellyBellyDb()
            : base("name=MyJellyBellyDb")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        //grab all the data from the data source and convert into JellyBelly objects
        public virtual DbSet<JellyBelly> JBSet { get; set; }
    }

    //create two properties: one to hold the category name and another to hold the category count/total 
    public partial class CategoryCount
    {
        public int Total{ get; set; }
        public string  Category { get; set; }
    }
}