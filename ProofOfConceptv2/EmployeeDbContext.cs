using Microsoft.EntityFrameworkCore;
using ProofOfConceptv2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProofOfConceptv2
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions options)
            :base(options)
        {

        }

        DbSet<Employee> Employees { get; set; }
    }
}
