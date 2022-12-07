using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP_ISIE_21.Model;

namespace TP_ISIE_21.Pages.Booklist
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book bUpdate { get; set; }
        public async Task OnGet(int id)
        {
            bUpdate = await _db.Livre.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
             var BookFromDb = await _db.Livre.FindAsync(bUpdate.Id);

             BookFromDb.Name = bUpdate.Name;
             BookFromDb.Author = bUpdate.Author;

            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
