using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.Entity
{
    public class StudentAddressEntity
    {
        public int StudentAddressId { get; set; }
        public string Address1 { get; set; }        

        public virtual StudentEntity Student { get; set; }
    }
}
