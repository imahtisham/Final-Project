using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class IndexexpModel : PageModel
    {
        IportsDbContext db;
        public Experience experience { get; set; }
        public IndexexpModel(IportsDbContext _db)
        {
            db = _db;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(Experience experience)
          
        {
            if (ModelState.IsValid)
            {
                db.tbl_Exp.Add(experience);
                db.SaveChanges();
                return RedirectToPage("showexp");
            }
            return Page();
           
        }
    }
}
