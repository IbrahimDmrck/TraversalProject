using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.Admin.Models
{
    public class ApiMovieViewModel
    {
        public int rank { get; set; }
        public string title { get; set; }
        public string rating { get; set; }
        public string year { get; set; }
        public string link { get; set; }
    }
}
