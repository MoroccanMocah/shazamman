using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamMan
{
    class program
    {
        static void Main(string[] args)
        {
            Artist Outkast = new Artist();
            Outkast.Name1 = "Outkast";
           
            Song s1 = new Song();
            s1.Artist = Outkast;
            s1.Duration = 71f;
            s1.Songtitle = "Hold on, Be Strong";

            Song s2 = new Song();
            s2.Artist = Outkast;
            s2.Duration = 349f;
            s2.Songtitle = "Return of the 'G'";

            Song s3 = new Song();
            s3.Artist = Outkast;
            s3.Duration = 324f;
            s3.Songtitle = "Hold on, Be Strong";

            Release aq = new Release();
            aq.ReleaseTitle = "Aquemni";
            aq.thisgen

        }
    }
}
