using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Debug.Assert(username != null && username.Length <= 100,
               "Username harus memiliki panjang maksimal 100 karakter dan tidak berupa null");

            this.username = username;
            this.id = new Random().Next(00001, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
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

        public List<SayaTubeVideo> GetVideoList()
        {
            return uploadedVideos;
        }

        public void AddVideo(SayaTubeVideo uploaded)
        {
            Debug.Assert(uploaded != null && uploaded.getCount() < int.MaxValue);
            uploadedVideos.Add(uploaded);
                
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + username);
            for (int i = 0; i < uploadedVideos.Count && i < 8; i++)
            {
                Console.WriteLine("Video "+(i+1)+" judul: " + uploadedVideos[i].getTitle());
            }
        }
        
    }
}
