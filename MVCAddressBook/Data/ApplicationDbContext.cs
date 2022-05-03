using Microsoft.EntityFrameworkCore;
using MVCAddressBook.Models;

namespace MVCAddressBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }


    }


}
