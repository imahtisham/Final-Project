using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class showexpModel : PageModel
    {
        IportsDbContext db;
        public List<Experience> experience { get; set; }
        public showexpModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            experience = db.tbl_Exp.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var abc = db.tbl_Exp.Find(Id);
            db.tbl_Exp.Remove(abc);
            db.SaveChanges();
            return RedirectToPage("showexp");
        }
    }
}
