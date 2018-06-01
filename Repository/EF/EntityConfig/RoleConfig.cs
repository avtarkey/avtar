using Repository.EF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.EntityConfig
{
    public class RoleConfig:EntityTypeConfiguration<RoleEntity>
    {
        public RoleConfig()
        {
            this.ToTable("T_Roles").HasKey<int>(r=>r.RoleId);
            this.HasMany<PermissionEntity>(r => r.Permissions)
                .WithMany(p => p.Roles)
                .Map(rp=>
                {
                    rp.MapLeftKey("RoleRefId");
                    rp.MapRightKey("PermissionRefId");
                    rp.ToTable("RolePermissions");
                });
        }
    }
}
