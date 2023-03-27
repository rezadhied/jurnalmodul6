using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213016
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public String username;

        public SayaTubeUser(String username)
        {
            this.id = new Random().Next(00001, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0, a = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos[i].getCount();
            }
            return total;
        } 

        public void AddVideo(SayaTubeVideo uploaded)
        {
            uploadedVideos.Add(uploaded);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video "+(i+1)+" judul: " + uploadedVideos[i].getTitle());
            }
        }
        
    }
}
