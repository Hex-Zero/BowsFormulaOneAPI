using BowsFormulaOneAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BowsFormulaOneAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserDto>().HasData(
                new UserDto { Id = 1, FirstName = "Maxwell", LastName = "Archer", EmployeeNumber = "r7jTG7dqBy5wGO4L"},
                new UserDto { Id = 2, FirstName = "Alexandra", LastName = "Archer", EmployeeNumber = "r7jTG8dqBy5wGO4L"}
            );
        }

        public DbSet<UserDto> Users { get; set; }
    }
}
