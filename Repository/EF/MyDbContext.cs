using Repository.EF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF
{
    public class MyDbContext:DbContext
    {
        public MyDbContext() : base("name=MyConnect")
        {
            Database.SetInitializer<MyDbContext>(new DropCreateDatabaseIfModelChanges<MyDbContext>());
        }

        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<GradeEntity> Grades { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //将当前程序集的所有继承自EntityTypeConfiguretion的类,加载为模型配置
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
