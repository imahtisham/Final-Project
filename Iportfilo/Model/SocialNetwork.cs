using System.ComponentModel.DataAnnotations;

namespace Iportfilo.Model
{
    public class SocialNetwork
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Your Facebook Link" )]
        public string Facebook { get; set; }

        [Required(ErrorMessage = "Enter Your Twiter Link")]

        public string Twiter { get; set; }

        [Required(ErrorMessage = "Enter Your Instagram Link")]

        public string  Instagram { get; set; }

        [Required(ErrorMessage = "Enter Your LinkdIn Link")]

        public string  Linkin { get; set; }

        [Required(ErrorMessage = "Enter Your Skype Link")]

        public string skype { get; set; }
    }
}
