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
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book b { get; set; }

        public async Task<IActionResult> OnPost(/*Book Book */) {
            if(!ModelState.IsValid) {
                return Page();
            }
            _db.Livre.Add(this.b);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}

    
