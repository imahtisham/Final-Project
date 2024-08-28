using System.ComponentModel.DataAnnotations.Schema;

namespace Iportfilo.Model
{
    public class Iportfiloes
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int  Age { get; set; }

        public string Degree { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Website { get; set; }
        public int PhoneNo { get; set; }
        public string  Freelancer{ get; set; }
        public string Birthday { get; set; }
        public string? Image { get; set; }
        [NotMapped]
        public IFormFile? Photo { get; set; }
    }
}
