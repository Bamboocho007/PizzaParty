using Microsoft.EntityFrameworkCore;
using PizzaParty.Models;

namespace PizzaParty.DB;

public class PostgresContext : DbContext
{
    protected readonly IConfiguration Configuration;
    public DbSet<Pizza> Pizzas { get; set; }

    public PostgresContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseNpgsql(Configuration.GetConnectionString("PostgresConnection"));
}
