using Famms.Data;
using Famms.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Pages.Pages
{
    public class ProductModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = ProductRepository.GetProducts();
        }
    }
}
