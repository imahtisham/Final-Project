using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class IndexportModel : PageModel
    {
        IportsDbContext db;
        IWebHostEnvironment env;
        public Iportfiloes iportfiloes { get; set; }
        public IndexportModel(IportsDbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env; 
        }
        public void OnGet()
        {
        }
        public void OnPost(Iportfiloes iportfiloes) 
        {
            string ImageName = iportfiloes.Photo.FileName.ToString();
            var FolderPath = Path.Combine(env.WebRootPath, "image");
            var Imagepath = Path.Combine(FolderPath, ImageName);
            FileStream fs = new FileStream(Imagepath, FileMode.Create);
            iportfiloes.Photo.CopyTo(fs);
            fs.Dispose();
            iportfiloes.Image = ImageName;
            db.tbl_Iport.Add(iportfiloes);
            db.SaveChanges();  
        }
    }
}
