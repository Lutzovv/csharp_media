using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    public class Movie : Media
    {
        public int Duration { get; set; }
        public string Director { get; set; }

        public Movie(int duration, string director, string title, string author, int yearPublished, bool isAvailable)
            : base(title, author, yearPublished, isAvailable)
        {
            Duration = duration;
            Director = director;
        }
    }
}
