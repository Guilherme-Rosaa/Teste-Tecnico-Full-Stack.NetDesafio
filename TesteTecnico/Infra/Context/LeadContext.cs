using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTecnico.Domain.Entities;

namespace TesteTecnico.Infra.Context
{
    public class LeadContext : DbContext
    {
        public DbSet<Lead> Leads { get; set; }

        public LeadContext(DbContextOptions<LeadContext> options) : base(options) { }
    }
}
