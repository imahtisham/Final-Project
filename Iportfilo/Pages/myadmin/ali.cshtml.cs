using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;

namespace Iportfilo.Pages.myadmin
{
    public class aliModel : PageModel
    {
        IportsDbContext db;
        public Skill skills { get; set; }
        public aliModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
         
        }
        public void OnPost(Skill skills) 
        {
            db.tbl_Skil.Add(skills);
            db.SaveChanges();
        }

    }
}
