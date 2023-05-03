using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    internal class SongRepo
    {
        static List<Song> _songs = new List<Song>
        {

        };
public static List<Song> Songs { get => _songs; set => _songs = value; }
    }
}
