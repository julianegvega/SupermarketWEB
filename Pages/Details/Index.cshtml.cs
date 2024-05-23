using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Details
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Detail> Details { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Details = await _context.Details.ToListAsync();
            }
        }
    }
}
