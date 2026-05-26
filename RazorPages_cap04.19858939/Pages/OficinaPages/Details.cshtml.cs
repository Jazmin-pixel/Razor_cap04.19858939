using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_cap04_19858939.Models;
using RazorPages_cap04_19858939.Data;

namespace RazorPages_cap04_19858939.Pages.OficinaPages;

public class DetailsModel : PageModel
{
    private readonly RazorPages_cap04_19858939Context _context;
    public DetailsModel(RazorPages_cap04_19858939Context context)
    {
        _context = context;
    }

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
}
