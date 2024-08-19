using Microsoft.EntityFrameworkCore;
using System;

namespace codefirstapi.Models
{
    public class friendContext:DbContext
    {
        public friendContext(DbContextOptions<friendContext> options) : base(options)
        {
        }

        public DbSet<People> Peoples { get; set; }
    }
}
