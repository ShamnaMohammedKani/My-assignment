using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement3
{
    public class Song
    {
        private string _name;
        private string _artist;
        private string _songType;
        private double _rating;
        private int _numOfDownloads;
        private DateTime _dateDownloaded;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; } 
            set {  _artist = value; } 
        }
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }
        }
        public double Rating
        { 
            get { return _rating; } 
            set { _rating = value; }
        }
        public int numOfDownloads
        { 
            get { return _numOfDownloads; }
            set { _numOfDownloads = value; }
        }
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set{_dateDownloaded = value; }
        }
       public Song()
        {

        }
        public Song(string name, string artist, string songType, double rating, int numOfDownloads, DateTime dateDownloaded)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numOfDownloads = numOfDownloads;
            _dateDownloaded = dateDownloaded;
               
            
        }
    }
  
}
