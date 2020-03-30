using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace test.Models
{
    public class ConnectionDBContextClass : DbContext
    {
        public ConnectionDBContextClass(DbContextOptions<ConnectionDBContextClass> options):base(options)
        {

        }

        public DbSet<PacientsClass> Заявки_на_консультацию { get; set; }
    }
}
