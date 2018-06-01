using Repository.EF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.EntityConfig
{
   public  class GradeConfig:EntityTypeConfiguration<GradeEntity>
    {
        GradeConfig()
        {
            this.ToTable("T_Grades");
            this.HasKey<int>(gr => gr.GradeId);
        }
    }
}
