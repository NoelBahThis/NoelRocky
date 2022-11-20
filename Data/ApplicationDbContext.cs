using Microsoft.EntityFrameworkCore;
using NoelRocky.Models;

namespace NoelRocky.Data
{
    public class ApplicationDbContext : DbContext
    {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Category> Category { get; set; }
		public DbSet<ApplicationType> ApplicationType { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<FavFood> FavFoods { get; set; }
    }
}
