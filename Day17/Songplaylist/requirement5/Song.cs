using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requirement5
{
    public class Song
    {
        private string _name;
        private string _artist;
        private string _songType;
        private double _rating;
        private int _numOfDownloads;
        private DateTime _dateDownloaded;
        private string v1;
        private string v2;
        private DateTime dt;
        private double d;
        private int nd;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
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
            set { _dateDownloaded = value; }
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

        public Song(string v1, string v2, DateTime dt, double d, int nd)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.dt = dt;
            this.d = d;
            this.nd = nd;
        }

        public static SortedDictionary<string, int> calculateTypeCount(List<Song> list)
        {
            SortedDictionary<string, int> sd1 = new SortedDictionary<string, int>();
            foreach (var item in list)
            {
                if (sd1.ContainsKey(item.Name))
                {
                    sd1[item.SongType]++;
                }
                else
                {
                    sd1.Add(item.SongType, 1);
                }
            }
            return sd1;
        }

        internal static SortedDictionary<string, int> CalculateTypeCount(object list)
        {
            throw new NotImplementedException();
        }
    } 
}



