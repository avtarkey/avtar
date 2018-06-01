using Repository.EF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.EntityConfig
{
    public class PermissionConfig:EntityTypeConfiguration<PermissionEntity>
    {
        public PermissionConfig()
        {
            this.ToTable("T_Permissions").HasKey<int>(p=>p.PermissionId);
            
        }
    }
}
