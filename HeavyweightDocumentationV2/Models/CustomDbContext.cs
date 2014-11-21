using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HeavyweightDocumentationV2.Models
{
    public class CustomDbContext : DbContext
    {
        /*************************/
        /**** DATABASE SCHEMA ****/
        /*************************/
        public DbSet<SiteUser> SiteUsers { get; set; }


        #region Initilization/Connection String stuff
        /*************************/
        /***** CONSTRUCTORS ******/
        /*************************/

        public CustomDbContext() : this("DefaultConnection")
        {

        }



        public CustomDbContext(string connectionString = "DefaultConnection")  // COULD HAVE CONNECTION STRING ISSUES HERE
            : base(connectionString)
        {
            //turn on DB wipes when in debug mode
            Database.SetInitializer<CustomDbContext>(new ContextModelChangeInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //called whenever the DB needs to be recreated due to model changes.
        public class ContextModelChangeInitializer : DropCreateDatabaseAlways<CustomDbContext>
        {
            protected override void Seed(CustomDbContext context)
            {
            }
        }
        #endregion
    }
}