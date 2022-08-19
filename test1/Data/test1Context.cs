using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnesAgcahan_Hafta_2;

namespace test1.Data
{
    public class test1Context : DbContext
    {
        public test1Context (DbContextOptions<test1Context> options)
            : base(options)
        {
        }

        public DbSet<EnesAgcahan_Hafta_2.Staff> Staff { get; set; } = default!;
    }
}
