using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_cap04_19858939.Models;
using RazorPages_cap04_19858939.Data;

namespace RazorPages_cap04_19858939.Pages.EmpleadoPages;

public class DeleteModel : PageModel
{
    private readonly RazorPages_cap04_19858939Context _context;

    public DeleteModel(RazorPages_cap04_19858939Context context)
    {
        _context = context;
    }

    [BindProperty]
    public Empleado Empleado { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var empleado = await _context.Empleado.FirstOrDefaultAsync(m => m.Id == id);
        if (empleado is null)
        {
            return NotFound();
        }
        else
        {
            Empleado = empleado;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var empleado = await _context.Empleado.FindAsync(id);
        if (empleado != null)
        {
            Empleado = empleado;
            _context.Empleado.Remove(Empleado);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
