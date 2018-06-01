﻿using Repository.EF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF.EntityConfig
{
    class StudentAddressConfig:EntityTypeConfiguration<StudentAddressEntity>
    {
        public StudentAddressConfig()
        {
            this.ToTable("T_StudentAddresses");
            this.HasKey<int>(ad => ad.StudentAddressId);
        }
    }
}
