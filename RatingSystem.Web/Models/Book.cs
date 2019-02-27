using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingSystem.Web.Models
{
    public class Book
    {
        public string Name { get; set; }
        public double AverageRating { get; set; }
        public int TotalRaters { get; set; }
        public double Ranking { get; set; }
    }
}
