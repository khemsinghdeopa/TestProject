using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrectish
{
    public class PlaylistItems:IComparable<PlaylistItems>
    {
        public int Playlistid { get; set; }        

        public int Counter { get; set; }

        public bool ISValid { get; set; } 
        

        public List<PlaylistInstance> instances { get; set; }

        public int CompareTo(PlaylistItems other)
        {
            throw new NotImplementedException();
        }
    }
}
