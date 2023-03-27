using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213016
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 200,
               "Judul video harus memiliki panjang maksimal 200 karakter dan tidak berupa null");

            this.id = new Random().Next(00001, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 25000000 && count >= 0 );
            this.playCount += count;
           

        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video Details:");
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }

        public int getCount()
        {
            return this.playCount;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
