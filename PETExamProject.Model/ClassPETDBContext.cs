using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETExamProject.Model
{
    public class ClassPETDBContext : DbContext 
    {
        public DbSet<ClassIndividual> Individuals { get; set; }

        public DbSet<ClassReport> Reports { get; set; }

        public DbSet<ClassNationality> Nationalities { get; set; }
    }
}
