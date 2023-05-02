
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = SongRepo.GetSongs();

            SortedDictionary<string, int> sd = Song.CalculateTypeCount(songs);


        }
    }
}
