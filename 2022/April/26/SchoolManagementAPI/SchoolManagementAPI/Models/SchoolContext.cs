using SchoolManagementAPI.DbConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolManagementAPI.Models
{
    public class SchoolContext : DbContext 
    {
        public SchoolContext() : base("SchoolDb")
        {
            //Database.SetInitializer<SchoolContext>(new SchoolDbInitializer());
            Database.SetInitializer(new CreateDatabaseIfNotExists<SchoolContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TeacherConfiguration());
            modelBuilder.Entity<Teacher>()
                .ToTable("Teacher");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}