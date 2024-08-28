using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class addfactModel : PageModel
    {
        IportsDbContext db;
        public List<Fact> fact { get; set; }
        public addfactModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            fact = db.tbl_Fact.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var abc = db.tbl_Fact.Find(Id);
            db.tbl_Fact.Remove(abc);
            db.SaveChanges();
            return RedirectToAction("addfact");
        }
    }
}
