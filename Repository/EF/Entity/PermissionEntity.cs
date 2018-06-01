using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.Entity
{
    public class PermissionEntity
    {
        public int PermissionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RoleEntity> Roles { get; set; } = new HashSet<RoleEntity>();
    }
}
