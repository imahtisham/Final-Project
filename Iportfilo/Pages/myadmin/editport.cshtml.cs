using Iportfilo.Data;
using Iportfilo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Iportfilo.Pages.myadmin
{
    public class editportModel : PageModel
    {
        IportsDbContext db;
        IWebHostEnvironment env;
        public Iportfiloes iportfiloes { get; set; }
        public editportModel(IportsDbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;
        }
        public void OnGet()
        {
            iportfiloes = db.tbl_Iport.FirstOrDefault();

        }
        public IActionResult OnPost(Iportfiloes iportfiloes)
        {
            if (iportfiloes.Photo is null)
            {
                db.tbl_Iport.Update(iportfiloes);
                db.SaveChanges();
            }
            else
            {

                string ImageName = iportfiloes.Photo.FileName.ToString();
                DeleteFile(iportfiloes.Image);
                var FolderPath = Path.Combine(env.WebRootPath, "image");
                var ImagePath = Path.Combine(FolderPath, ImageName);
                var myFileStream = new FileStream(ImagePath, FileMode.Create);
                iportfiloes.Photo.CopyTo(myFileStream);
                myFileStream.Dispose();
                iportfiloes.Image = ImageName;
                db.tbl_Iport.Update(iportfiloes);
                db.SaveChanges();
            }
            return RedirectToPage("editport");
        }
        private void DeleteFile(string OldImageName)
        {
            var FolderPath = Path.Combine(env.WebRootPath, "image");
            var ImagePath = Path.Combine(FolderPath, OldImageName);
            FileInfo fileInfo = new FileInfo(ImagePath);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

        }
    }
}
    
