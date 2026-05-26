using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_cap04_19858939.Models;
using RazorPages_cap04_19858939.Data;

namespace RazorPages_cap04_19858939.Pages.EmpleadoPages;

public class CreateModel : PageModel
{
    private readonly RazorPages_cap04_19858939Context _context;

    public CreateModel(RazorPages_cap04_19858939Context context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public Empleado Empleado { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Empleado.Add(Empleado);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
