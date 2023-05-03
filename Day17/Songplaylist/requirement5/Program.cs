using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace requirement5
{
    internal class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            List<Song>ls=new List<Song>();
            Console.WriteLine("enter number of songs: ");
            int n=int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string[]s=Console.ReadLine().Split(' ');
                double d = double.Parse(s[4]);
                int nd = int.Parse(s[5]);
                DateTime dt = new DateTime();
               
                Song s1 = new Song(s[0], s[1], s[2], d, nd,dt);
                ls.Add(s1);
            } 
            SortedDictionary<string,int>sd1 = new SortedDictionary<string,int>();
            sd1=Song.CalculateTypeCount(list);
            Console.WriteLine("{0}{1,15}", "Song-type \t count");

            foreach(var item in sd1)
            {
                Console.WriteLine(item.Key+"\t\t"+item.Value);
            }
        }
    }
}
