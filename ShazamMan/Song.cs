using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShazamMan
{
    class Song
    {
        private string _songtitle;
        private Artist _artist;
        private float _duration;

        public string Songtitle { get => _songtitle; set => _songtitle = value; }
       
       
        public float Duration { get => _duration; set => _duration = value; }
       
        internal Artist Artist { get => _artist; set => _artist = value; }
    }
}
