using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages
{
    public class IndexModel : PageModel
    {
        IportsDbContext db;
        public Iportfiloes? iportfiloes { get; set; }
        public Fact? fact { get; set; }
        public List<Skill> skill { get; set; }
        public List<Education> edu { get; set; }
        public List<Experience> exp { get; set; }
        public List<Services> scr { get; set; }
        public Contect con { get; set; }
        public IndexModel(IportsDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            iportfiloes = db.tbl_Iport.FirstOrDefault();
            fact = db.tbl_Fact.FirstOrDefault();
            skill = db.tbl_Skil.ToList();
            edu = db.tbl_Edu.ToList();
            exp = db.tbl_Exp.ToList();
            scr = db.tbl_Ser.ToList();


        }
        public IActionResult Onpost(Contect con)
        {
            db.tbl_Context.Add(con);
            db.SaveChanges();
            return RedirectToPage("Index");
            
        }
    }
}
