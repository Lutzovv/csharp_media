using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    public class Book : Media
    {
        public int Pages {  get; set; }
        public string Genre { get; set; }

        public Book(int pages, string genre, string title, string author, int yearPublished, bool isAvailable)
            : base(title, author, yearPublished, isAvailable)
        {
            Pages = pages;
            Genre = genre;
        }
    }
}
