namespace PizzaGram.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using PizzaGram.Data.Models;

    public class PizzaGramDbContext : IdentityDbContext<User>
    {
        public PizzaGramDbContext(DbContextOptions<PizzaGramDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> ApplicationUsers { get; set; }
    }
}
