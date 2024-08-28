using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class showcontModel : PageModel
    {
        IportsDbContext db;
        public List <Contect> con { get; set; }
        public showcontModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            con = db.tbl_Context.ToList();
        }
        public IActionResult OnGetDelete(int id)
        {
            var abc = db.tbl_Context.Find(id);
            db.tbl_Context.Remove(abc);
            db.SaveChanges();
            return RedirectToAction("showcont");   
        }
    }
}
