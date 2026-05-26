using Microsoft.EntityFrameworkCore;
using RazorPages_cap04_19858939.Models;


namespace RazorPages_cap04_19858939.Data // <--- AGREGA ESTO
{
    public class RazorPages_cap04_19858939Context : DbContext
    {
        public DbSet<RazorPages_cap04_19858939.Models.Oficina> Oficina { get; set; } = default!;
        public DbSet<RazorPages_cap04_19858939.Models.Cliente> Cliente { get; set; } = default!;
        public RazorPages_cap04_19858939Context(DbContextOptions<RazorPages_cap04_19858939Context> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleado { get; set; } = default!;
    }
} // <--- ASEGÚRATE DE CERRAR LA LLAVE DEL NAMESPACE