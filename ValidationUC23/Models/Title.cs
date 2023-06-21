using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationUC23.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string Description { get; set; }
        public int? ReleaseYear { get;set; }
        public string AgeCertification { get; set; }
        public int? Runtime { get;set; }
        public string Genres { get;set; }   
        public string ProductionCountry { get;set; }
        public int? Seasons { get;set; }
    }
}
