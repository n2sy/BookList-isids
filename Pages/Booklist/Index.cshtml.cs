using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using TP_ISIE_21.Model;

namespace TP_ISIE_21.Pages.Booklist
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Book> Books { get; set;} 
                                                  
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            Books = await _db.Livre.ToListAsync();
            //......
            
        }

        public async Task<IActionResult> OnDelete(int id)
        {
            var book = await _db.Livre.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _db.Livre.Remove(book);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");

        }

    }
}
