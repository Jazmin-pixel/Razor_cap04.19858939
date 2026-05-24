using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace RazorPages_cap04._19858939.Pages.Empleados
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? nombre { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                nombre = "Empleado 1";
            }
        }
    }
}
