using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class factModel : PageModel
    { 
        IportsDbContext db;
        public Fact facts { get; set; }
        public factModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost(Fact fact) 
        { 
            db.tbl_Fact.Add(fact);
            db.SaveChanges();
            return RedirectToPage("addfact");
        }
    }
}
