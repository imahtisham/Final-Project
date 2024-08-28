using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class showskilModel : PageModel
    {
        IportsDbContext db;
        public List<Skill> skills { get; set; }
        public showskilModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            skills = db.tbl_Skil.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var abc = db.tbl_Skil.Find(Id);
            db.tbl_Skil.Remove(abc);
            db.SaveChanges();
            return RedirectToPage("showskil");
        }
    }
}
