using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Streja_Raluca_Lab2.Data;
using Streja_Raluca_Lab2.Models;

namespace Streja_Raluca_Lab2.Pages.Books
    {
    public class DetailsModel(Streja_Raluca_Lab2Context context) : PageModel
        {
        private readonly Streja_Raluca_Lab2Context _context = context;

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
            {
            if (id == null)
                {
                return NotFound();
                }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
                {
                return NotFound();
                }
            else
                {
                Book = book;
                }
            return Page();
            }
        }
    }
