using Repository.EF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.EntityConfig
{
    class StConfig : EntityTypeConfiguration<Student>
    {
        public StConfig()
        {
            this.ToTable("T_Students");
            this.HasOptional(st => st.Address).WithRequired(ad => ad.Student);
            this.HasKey<int>(st => st.Id);
        }
    }
}
