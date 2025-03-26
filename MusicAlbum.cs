using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    public class MusicAlbum : Media
    {
        public string Executor {  get; set; }
        public int Count_of_tracks { get; set; }

        public MusicAlbum( string executor, int count_of_tracks, string title, string author, int yearPublished, bool isAvailable)
        : base(title, author, yearPublished, isAvailable)
        {
            Executor = executor;
            Count_of_tracks = count_of_tracks;
        }

    }
}
