using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {
        }
        public DbSet<ContactDTO> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {        
        }
    }
}
