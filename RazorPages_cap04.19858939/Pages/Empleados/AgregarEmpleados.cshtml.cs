using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_cap04._19858939.Models;

namespace RazorPages_cap04._19858939.Pages.Empleados
{
    public class AgregarEmpleadosModel : PageModel
    {
        [BindProperty]
        public Empleado Empleado { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Empleados/Index", new { nombre = Empleado.Nombre });
        }
    }
}
