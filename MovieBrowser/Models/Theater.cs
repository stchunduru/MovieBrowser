using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBrowser.Models
{
    public class Theater
    {
        [Key]
        public int Id { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Movie> Movie { get; set; }

    }
}
