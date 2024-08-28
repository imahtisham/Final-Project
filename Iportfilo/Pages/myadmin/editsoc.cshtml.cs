using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class editsocModel : PageModel
    {
        IportsDbContext db;
        public SocialNetwork socialNetwork { get; set; }
        public editsocModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            socialNetwork = db.tbl_Social.Find(Id);
        }
        public IActionResult OnPost(SocialNetwork socialNetwork)
        {
            db.tbl_Social.Update(socialNetwork);
            db.SaveChanges();
            return RedirectToPage("socnetadd");
        }
    }
}
