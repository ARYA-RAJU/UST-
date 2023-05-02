using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Requirement4

{

    class PopularityComparer : IComparer<Song>

    {

        public int Compare(Song x, Song y)

        {

            return y.NumberofDownloads.CompareTo(x.NumberofDownloads);

        }

    }

}