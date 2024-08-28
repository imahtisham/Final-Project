using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class IndexserviceModel : PageModel
    {
        IportsDbContext db;
        public Services services { get; set; }
        public IndexserviceModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            services = db.tbl_Ser.Find(Id);
        }
        public void OnPost(Services services) 
        {
            db.tbl_Ser.Add(services);
            db.SaveChanges();
        }
    }
}
