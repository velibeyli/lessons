using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolManagementAPI.Models
{
    public class SchoolDbInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<Grade> grades = new List<Grade>();
            grades.Add(new Grade() { Name = "Grade A" });
            grades.Add(new Grade() { Name = "Grade B" });
            grades.Add(new Grade() { Name = "Grade C" });

            context.Grades.AddRange(grades);
            base.Seed(context);
        }
    }
}