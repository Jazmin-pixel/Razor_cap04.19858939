using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_cap04_19858939.Models;
using RazorPages_cap04_19858939.Data;

namespace RazorPages_cap04_19858939.Pages.EmpleadoPages;

public class IndexModel : PageModel
{
    private readonly RazorPages_cap04_19858939Context _context;

    public IndexModel(RazorPages_cap04_19858939Context context)
    {
        _context = context;
    }

    public IList<Empleado> Empleado { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Empleado = await _context.Empleado.ToListAsync();
    }
}
