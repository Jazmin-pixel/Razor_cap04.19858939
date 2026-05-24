using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_cap04._19858939.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        public string[] ListaClientes { get; set; }
        public void OnGet()
        {
            ListaClientes = new string[]
            {
                 "Monica Martinez",
                 "Erick Miguel",
                 "Valexita",
                 "Lisexita",
                 "Marjoxita"
            };
        }

    }
}
