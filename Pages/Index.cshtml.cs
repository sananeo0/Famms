using Famms.Data;
using Famms.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Famms.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = ProductRepository.GetProducts();
        }
    }
}
