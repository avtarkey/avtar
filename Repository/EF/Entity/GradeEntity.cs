using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.Entity
{
    public  class GradeEntity
    {
    public int GradeId { get; set; }
    public string GradeName { get; set; }
    

    public ICollection<StudentEntity> Students { get; set; }
}
}
