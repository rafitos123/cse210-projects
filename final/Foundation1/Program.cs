using System;

class Program
{
    static void Main(string[] args)
    {

        //comments
        List<Comments> FirstComments = new List<Comments>();
        Comments insert1 = new Comments("Rafael","Nice video!");
        FirstComments.Add(insert1);
        Comments insert2 = new Comments("Douglas","Can you create another video like this please?");
        FirstComments.Add(insert2);
        Comments insert3 = new Comments("Peter","Thank you!");
        FirstComments.Add(insert3);
        
        List<Comments> SecondComments = new List<Comments>();
        Comments insert4 = new Comments("Chico","Wooooow!!!");
        SecondComments.Add(insert4);
        Comments insert5 = new Comments("Nilce","I like it!");
        SecondComments.Add(insert5);
        Comments insert6 = new Comments("Leon","Very good");
        SecondComments.Add(insert6);
        Comments insert7 = new Comments("Maria","THIS WAS AWESOME!");
        SecondComments.Add(insert7);

        List<Comments> ThirdComments = new List<Comments>();
        Comments insert8 = new Comments("Laura","Dislike :(");
        ThirdComments.Add(insert8);
        Comments insert9 = new Comments("Fernando","I believe this!");
        ThirdComments.Add(insert9);
        Comments insert10 = new Comments("Higor","Maybe those things are not true");
        ThirdComments.Add(insert10);

        //videos
        List<Youtube> youtube = new List<Youtube>();
        Youtube video1 = new Youtube("How to add a preset on Ligthroom","PhotoCrazy",360, FirstComments);
        youtube.Add(video1);
        Youtube video2 = new Youtube("All I want - Kodaline Cover","GuitarPro",400, SecondComments);
        youtube.Add(video2);
        Youtube video3 = new Youtube("Top 10 crazy things","This Fact",500, ThirdComments);
        youtube.Add(video3);

        //loop
        foreach(Youtube videos in youtube)
        {
            Console.WriteLine($"{videos._title}");
            Console.WriteLine($"by:{videos._author}");
            Console.WriteLine($"{videos._length} seconds");
            Console.WriteLine($"{videos.GetNumberComments()} comments");

            foreach(Comments comment in videos.GetComments())
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}