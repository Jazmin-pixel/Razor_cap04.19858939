using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_cap04_19858939.Models;
using RazorPages_cap04_19858939.Data;

namespace RazorPages_cap04_19858939.Pages.OficinaPages;

public class DeleteModel : PageModel
{
    private readonly RazorPages_cap04_19858939Context _context;

    public DeleteModel(RazorPages_cap04_19858939Context context)
    {
        _context = context;
    }

    [BindProperty]
    public Oficina Oficina { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var oficina = await _context.Oficina.FirstOrDefaultAsync(m => m.id == id);
        if (oficina is null)
        {
            return NotFound();
        }
        else
        {
            Oficina = oficina;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var oficina = await _context.Oficina.FindAsync(id);
        if (oficina != null)
        {
            Oficina = oficina;
            _context.Oficina.Remove(Oficina);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
