using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class showservicecshtmlModel : PageModel
    { 
        IportsDbContext db;
        public List <Services> services { get; set; }
        public showservicecshtmlModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            services = db.tbl_Ser.ToList();
        }
        public void OnGetDelete(int Id)
        {
           var abc = db.tbl_Ser.Find(Id);
            db.tbl_Ser.Remove(abc);
            db.SaveChanges();
        }
    }
}
