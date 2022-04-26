using SchoolManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SchoolManagementAPI.DbConfig
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            this.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(s => s.Surname)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}