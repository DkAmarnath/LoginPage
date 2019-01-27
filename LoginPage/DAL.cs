using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LoginPage.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LoginPage
{
    public class DAL:DbContext
    {
        public DAL() : base("Databaseentity")
        {

        }
        public DbSet<CityModel> CityModel { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}