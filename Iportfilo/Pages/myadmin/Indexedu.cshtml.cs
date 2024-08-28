using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

namespace Iportfilo.Pages.myadmin
{
    public class Index1Model : PageModel
    {
        IportsDbContext db;
        public Education education { get; set; }
        public Index1Model(IportsDbContext _db)
        {
            db = _db;

        }

        public void OnGet(int Id)
        {
            education = db.tbl_Edu.Find(Id);
        }
        public IActionResult OnPost(Education education)
        {
                 if(ModelState.IsValid)
            {
                db.tbl_Edu.Add(education);
                db.SaveChanges();
                return RedirectToPage("showstd");
            }
            return Page();
    }
         




        }
    }

