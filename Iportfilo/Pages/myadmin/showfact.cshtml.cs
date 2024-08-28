using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class showfactModel : PageModel
    {
        IportsDbContext db;
        public Fact fact { get; set; }
        public showfactModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            fact = db.tbl_Fact.Find(Id);
        }
        public void OnPost(Fact fact) 
        {
            db.tbl_Fact.Update(fact);
            db.SaveChanges();
        }
    }
}
