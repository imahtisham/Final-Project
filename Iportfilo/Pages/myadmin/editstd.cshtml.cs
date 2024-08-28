using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class editstdModel : PageModel
    {
        IportsDbContext db;
        public Education education { get; set; }
        public editstdModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            education = db.tbl_Edu.Find(Id);
        }
        public IActionResult OnPost(Education education)
        {
            db.tbl_Edu.Update(education);
            db.SaveChanges();
            return RedirectToPage("showstd");
        }
    } 
}
