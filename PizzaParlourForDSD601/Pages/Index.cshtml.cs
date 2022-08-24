using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaParlourForDSD601.Models;
using PizzaParlourForDSD601.Operations;

namespace PizzaParlourForDSD601.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public int? PizzaFlavour { get; set; }

        public Pizza pizza { get; set; }
        public bool IsFirstLoad { get; set; } = false;
        public IndexModel()
        {

        }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            IsFirstLoad = true;
            pizza = Factory.GetAPizza(id: PizzaFlavour);
            return Page();
        }
    }
}