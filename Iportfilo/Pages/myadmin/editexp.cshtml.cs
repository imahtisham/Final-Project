using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class editexpModel : PageModel
    {
        IportsDbContext db;
        public Experience experience { get; set; }
        public editexpModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            experience = db.tbl_Exp.Find(Id);
        }
        public  IActionResult OnPost( Experience experience) 
        { 
            db.tbl_Exp.Update(experience);
            db.SaveChanges();
            return RedirectToPage("showexp");

        }
    }
}
