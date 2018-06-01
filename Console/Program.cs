using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.EF;
using Repository.EF.Entity;

namespace avtar
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                //var stp = new StudentEntity() { StudentName = "po" };
                //var gra = new GradeEntity() { GradeName = "wode" };
                //stp.CurrentGrade = gra;

                //ctx.Set<StudentEntity>().Add(stp);

                var grade = ctx.Grades.SingleOrDefault(gr => gr.GradeName == "wode");
                if (grade != null)
                {
                    ctx.Grades.Remove(grade);
                }            



                ctx.SaveChanges();
            }


        }
    }
}
