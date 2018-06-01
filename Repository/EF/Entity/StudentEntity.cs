using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.Entity
{
    public class StudentEntity
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int CurrentGradeId { get; set; }
        public GradeEntity CurrentGrade { get; set; }
    }
}
