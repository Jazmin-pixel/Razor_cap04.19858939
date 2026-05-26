using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_cap04_19858939.Models;
using RazorPages_cap04_19858939.Data;

namespace RazorPages_cap04_19858939.Pages.EmpleadoPages;

public class EditModel : PageModel
{
    private readonly RazorPages_cap04_19858939Context _context;

    public EditModel(RazorPages_cap04_19858939Context context)
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
        Empleado = empleado;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Empleado).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EmpleadoExists(Empleado.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool EmpleadoExists(int id)
    {
        return _context.Empleado.Any(e => e.Id == id);
    }
}
