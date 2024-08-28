using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class editskilModel : PageModel
    {
        IportsDbContext db;
        public Skill skills { get; set; }
        public editskilModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost(Skill skills)
        {
            db.tbl_Skil.Add(skills);
            db.SaveChanges();
            return RedirectToPage("showskil");
        }
    }
}
