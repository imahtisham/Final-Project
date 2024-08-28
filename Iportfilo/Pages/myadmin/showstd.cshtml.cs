using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class showstdModel : PageModel
    {
        IportsDbContext db;
        public List<Education> education { get; set; }
        public showstdModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            education = db.tbl_Edu.ToList();
            
        }
        public  IActionResult OnGetDelete(int id)
        {
            var abc = db.tbl_Edu.Find(id);
            db.tbl_Edu.Remove(abc);
            db.SaveChanges();
            return RedirectToPage("showstd");
              
        }
    }
}
