using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBrowser.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Biography { get; set; }
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
