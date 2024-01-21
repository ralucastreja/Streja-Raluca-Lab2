using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Streja_Raluca_Lab2.Models;

namespace Streja_Raluca_Lab2.Pages.Books
    {
    public class CreateModel(Data.Streja_Raluca_Lab2Context context) : PageModel
        {
        private readonly Data.Streja_Raluca_Lab2Context _context = context;

        public IActionResult OnGet()
            {
            ViewData["Authors"] = new SelectList(_context.Set<Author>(), "ID", "FullName");
            ViewData["Publishers"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");

            return Page();
            }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
            {
            if (!ModelState.IsValid)
                {
                return Page();
                }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
            }
        }
    }
