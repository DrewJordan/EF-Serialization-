using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Entities
{
    public class EFContext : DbContext
    {
        public DbSet<MyDBEntity> Entities { get; set; }
    }
}
