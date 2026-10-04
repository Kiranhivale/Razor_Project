using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Data;
using Razor.Model;
namespace Razor.Pages.Categories
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }

        private ApplicationDbContext _context;
        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            Category = _context.Categories.Find(id);
        }

        public async Task<IActionResult>OnPost()
        {
            if (ModelState.IsValid)
            {
                 _context.Categories.Update(Category);
                await _context.SaveChangesAsync();

                return RedirectToPage("Category");
            }
            return Page();

        }
    }
}
