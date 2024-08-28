using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class editserviceModel : PageModel
    {
        IportsDbContext db;
        public Services services { get; set; }
        public editserviceModel(IportsDbContext _db)
        {
            db = _db;
            
        }
        public void OnGet(int Id)
        {
            services = db.tbl_Ser.Find(Id);
        }
        public void OnPost(Services services)
        {
            db.tbl_Ser.Update(services);
            db.SaveChanges();
        }
    }
}
