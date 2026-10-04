using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Model;
using Razor.Data;

namespace Razor.Pages.Categories
{
    public class CategoryModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IEnumerable<Category> Categories { get; set; }

        public CategoryModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
      {
            Categories = _context.Categories;
        }

    }
}
