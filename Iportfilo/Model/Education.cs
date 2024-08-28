using System.ComponentModel.DataAnnotations;

namespace Iportfilo.Model
{
    public class Education
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Please Enter Your degree")]
        public string Degree { get; set; }
        [Required(ErrorMessage = "Please Enter Your startyear")]
        public string startyear { get; set; }
         
        [Required(ErrorMessage = "Please Enter Your endyear")]
        public string endyear{ get; set; }
        [Required(ErrorMessage = "Please Enter Your InsistueNam")]
        public string InsistueName { get; set; }

    }
}
