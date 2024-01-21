using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Streja_Raluca_Lab2.Models;

namespace Streja_Raluca_Lab2.Pages.Books
    {
    public class IndexModel(Data.Streja_Raluca_Lab2Context context) : PageModel
        {
        private readonly Data.Streja_Raluca_Lab2Context _context = context;

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
            {
            Book = await _context.Book
                .Include(a => a.Author)
                .Include(p => p.Publisher)
                .ToListAsync();
            }
        }
    }
