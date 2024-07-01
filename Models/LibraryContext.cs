
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Web.Models

{
    public class LibraryContext : IdentityDbContext<IdentityUser>
	{
		public LibraryContext(DbContextOptions<LibraryContext> options): base(options)
        {
        }

		public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}