using Microsoft.EntityFrameworkCore;

public class RazorPages_cap04_19858939Context(DbContextOptions<RazorPages_cap04_19858939Context> options) : DbContext(options)
{
    public DbSet<RazorPages_cap04._19858939.Models.Empleado> Empleado { get; set; } = default!;
}
