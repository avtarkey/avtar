using Repository.EF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.EntityConfig
{
    public class StudentConfig:EntityTypeConfiguration<StudentEntity>
    {
        public StudentConfig()
        {
            this.ToTable("T_Students");
            this.HasRequired(st => st.CurrentGrade).WithMany(ad => ad.Students).HasForeignKey<int>(st=>st.CurrentGradeId);
            this.HasKey<int>(st => st.StudentId);
            


        }
    }
}
