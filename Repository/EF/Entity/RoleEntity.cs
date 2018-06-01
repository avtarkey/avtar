using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.Entity
{
    public class RoleEntity
    {
        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PermissionEntity> Permissions { get; set; } = new HashSet<PermissionEntity>();
    }
}
