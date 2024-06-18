using Microsoft.EntityFrameworkCore;
using ContactManagerApi.Models;
using System.Collections.Generic;

namespace ContactManagerApi.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
