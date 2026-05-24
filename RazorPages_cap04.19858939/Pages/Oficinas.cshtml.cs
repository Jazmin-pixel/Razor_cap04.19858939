using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_cap04._19858939.Pages
{
    public class OficinasModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public void OnGet()
        {
            if(id==0)
            {
                id = 1;
            }
        }
    }
}
