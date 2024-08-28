using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class showsocModel : PageModel
    {
        IportsDbContext db;
        public List<SocialNetwork> socialNetwork { get; set; }
        public showsocModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            socialNetwork = db.tbl_Social.ToList();
        }
        public IActionResult OnGetDelete(int Id) 
        {
            var abc = db.tbl_Social.Find(Id);
            db.tbl_Social.Remove(abc);
            db.SaveChanges();
            return RedirectToPage("showsoc");
        }
    }
}
