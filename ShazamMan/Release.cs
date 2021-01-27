using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamMan
{
    enum ReleaseType
    {
        Single,
        MaxiSingle,
        EP,
        Album
    }
    enum Genre
    {
    country,
    rap,
    rock,
    edm
    }


    class Release
    {
        public string ReleaseTitle;
        private DateTime _releaseDate;
        public ReleaseType thisReleaseType;
        public Genre thisGenre;
        public Artist thisArtist;

    }
}
