using SOL_MARIO_HUAMAN.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SOL_MARIO_HUAMAN.DAL
{
    public class MarioContext : DbContext
    {
        public MarioContext() : base("MarioContext")
        {
        }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}