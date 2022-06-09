using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RiadaLite.Models.Users;

namespace RiadaLite.Models
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options): base(options)
        {

        }
        public DbSet<Persona> Persona { get; set; }
    }
}
