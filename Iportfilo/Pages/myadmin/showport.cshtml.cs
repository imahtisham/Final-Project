using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class showportModel : PageModel
    {
        IportsDbContext db;
        public List<Iportfiloes> iportfiloes { get; set; }
        public showportModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            iportfiloes = db.tbl_Iport.ToList();
        }
        public void OnGetDelete(int Id) 
        {
            var abc = db.tbl_Iport.Find(Id);
            db.tbl_Iport.Remove(abc);
            db.SaveChanges();
        }
    }
}
