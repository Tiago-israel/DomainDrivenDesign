using Domain.Models;
using Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DataContext
{
    public class Context : DbContext
    {
        public  Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public virtual DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new PessoaMap());
        }
    }
}
