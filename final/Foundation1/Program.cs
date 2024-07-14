public class Program
{
    public static void Main(string[] args)
    {
        // makes vids, numbers differing them
        Video video1 = new Video("How to steal the Moon!", "Gru", 600);
        Video video2 = new Video("Goku vs Naruto", "NerdEmoji", 1800);
        Video video3 = new Video("Is Alvin and the Chipmunks Nightcore?!?!", "musicman", 1200);

        // add comments
        video1.AddComment(new Comment("Hank", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "guys wheres the moon"));
        video1.AddComment(new Comment("Vector", "this is lame sauce and im better than you"));

        video2.AddComment(new Comment("NarutoLover101", "This is so dumb goku would defo lose"));
        video2.AddComment(new Comment("Goku4president", "this is so great i LOVE goku"));
        video2.AddComment(new Comment("animeisevil", "you are dumb you are dumb you are dumb"));

        video3.AddComment(new Comment("__AngelWing__", "Nightcore!!!!!"));
        video3.AddComment(new Comment("Boberto", "chipmunks arent even real"));
        video3.AddComment(new Comment("alvinsimontheodore", "pls make more alvin and chipmunk vids"));


        // videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };


        // shows vid info
        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine();
        }
    }
}
