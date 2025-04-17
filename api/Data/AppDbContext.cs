using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext {
    public DbSet<Game> Games { get; set; }
    public DbSet<Character> Characters { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}
