using DatingApp.App.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.App.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Value> Values {get; set;}
    }
}