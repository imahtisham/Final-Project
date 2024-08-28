using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class IndexsocModel : PageModel
    {
        IportsDbContext db;
        public SocialNetwork socialNetwork { get; set; }
        public IndexsocModel(IportsDbContext _db)

        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            socialNetwork = db.tbl_Social.Find(Id);
        }
        public IActionResult OnPost(SocialNetwork socialNetwork) 
        {
            if(ModelState.IsValid)
            {
                db.tbl_Social.Add(socialNetwork);
                db.SaveChanges();
            }
            return Page();
        }
    }
}
