using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBrowser.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }

        public List<Movie> Movies { get; set; }

    }
}
