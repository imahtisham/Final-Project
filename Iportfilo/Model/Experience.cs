using System.ComponentModel.DataAnnotations;

namespace Iportfilo.Model
{
    public class Experience
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Startyear")]
        public string startyear { get; set; }
        [Required(ErrorMessage ="Enter EndYear")]
        public string endyear{ get; set; }
        [Required(ErrorMessage ="EnterJob Title ")]
        public string JobTitle{ get; set; }
        [Required(ErrorMessage ="Enter Job Description")]
        public string Dec { get; set; }
        [Required(ErrorMessage ="Enter Location")]
        public string  Location { get; set; }
    }
}
