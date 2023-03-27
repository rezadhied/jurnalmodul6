using modul6_1302213016;
using System;

namespace tpmodul6_1302213016
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo v1 = new SayaTubeVideo("Review Film Inception oleh Reza Adhie Dharmawan");
            SayaTubeVideo v2 = new SayaTubeVideo("Review Film Boboiboy oleh Reza Adhie Dharmawan");
            SayaTubeVideo v3 = new SayaTubeVideo("Review Film Spongebob oleh Reza Adhie Dharmawan");
            SayaTubeVideo v4 = new SayaTubeVideo("Review Film Transformers oleh Reza Adhie Dharmawan");
            SayaTubeVideo v5 = new SayaTubeVideo("Review Film Interstellar oleh Reza Adhie Dharmawan");
            SayaTubeVideo v6 = new SayaTubeVideo("Review Film Avengers oleh Reza Adhie Dharmawan");
            SayaTubeVideo v7 = new SayaTubeVideo("Review Film Tulsa King oleh Reza Adhie Dharmawan");
            SayaTubeVideo v8 = new SayaTubeVideo("Review Film Spider-Man oleh Reza Adhie Dharmawan");
            SayaTubeVideo v9 = new SayaTubeVideo("Review Film Iron Man oleh Reza Adhie Dharmawan");
            SayaTubeVideo v10 = new SayaTubeVideo("Review Film Ashiap Man oleh Reza Adhie Dharmawan");
            v1.IncreasePlayCount(111);
            v2.IncreasePlayCount(112);
            v3.IncreasePlayCount(120);
            v4.IncreasePlayCount(121);
            v5.IncreasePlayCount(122);
            v6.IncreasePlayCount(132);
            v7.IncreasePlayCount(123);
            v8.IncreasePlayCount(543);
            v9.IncreasePlayCount(566);
            v10.IncreasePlayCount(124);

            try
            {
                SayaTubeUser user = new SayaTubeUser("Reza");
                user.AddVideo(v1);
                user.AddVideo(v2);
                user.AddVideo(v3);
                user.AddVideo(v4);
                user.AddVideo(v5);
                user.AddVideo(v6);
                user.AddVideo(v7);
                user.AddVideo(v8);
                user.AddVideo(v9);
                user.AddVideo(v10);

                user.PrintAllVideoPlaycount();
                int x = user.GetTotalVideoPlayCount();
                Console.WriteLine("Total Video PLaycount: " + x);

                Console.WriteLine("\n\nPENGUJIAN KONDISI\n");

                SayaTubeVideo video1 = new SayaTubeVideo(null);
                SayaTubeVideo video2 = new SayaTubeVideo("Video tes playcount");
                for (int i = 0; i < 100; i++)
                {
                    video2.IncreasePlayCount(9999999);
                }

                SayaTubeUser user2 = new SayaTubeUser(null);
                user2.AddVideo(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            

        }
    }
}