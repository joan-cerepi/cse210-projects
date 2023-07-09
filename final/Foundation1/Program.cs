using System;

class Program
{
    private static List<Video> _videos = new List<Video>();

    static void Main(string[] args)
    {
        Console.WriteLine("Abstraction with YouTube Videos Project");
        Console.WriteLine();

        PopulateVideo1();
        PopulateVideo2();
        PopulateVideo3();

        foreach(Video video in _videos)
        {
            video.DisplayVideoInformation();
        }
    }

    static void PopulateVideo1() {
        Video video = new Video("Exploring Ancient Ruins", "Adventurer123", 57);

        Comment comment1 = new Comment();
        comment1.SetName("Ethan Thompson");
        comment1.SetText("Wow, the ancient ruins look so mysterious!");
        
        Comment comment2 = new Comment();
        comment2.SetName("Noah Davis");
        comment2.SetText("I know, right? It's incredible how they've stood the test of time.");
        
        Comment comment3 = new Comment();
        comment3.SetName("Ethan Thompson");
        comment3.SetText("Definitely! I would love to visit them someday.");

        video.AddComment(comment1);
        video.AddComment(comment2);
        video.AddComment(comment3);

        _videos.Add(video);
    }

    static void PopulateVideo2() {
        Video video = new Video("Delicious Recipes: Homemade Pizza", "ChefCookingMaster", 78);

        Comment comment1 = new Comment();
        comment1.SetName("Ava Rodriguez");
        comment1.SetText("That homemade pizza looks absolutely delicious! Can't wait to try making it myself.");
        
        Comment comment2 = new Comment();
        comment2.SetName("Mason Taylor");
        comment2.SetText("Great recipe! I followed your instructions and the pizza turned out amazing. Thanks for sharing!");
        
        Comment comment3 = new Comment();
        comment3.SetName("Alice Johnson");
        comment3.SetText("I'm a big fan of homemade pizza. Your video just made me crave it even more!");

        video.AddComment(comment1);
        video.AddComment(comment2);
        video.AddComment(comment3);

        _videos.Add(video);
    }

    static void PopulateVideo3() {
        Video video = new Video("Mastering Guitar Techniques", "MusicLover27", 124);

        Comment comment1 = new Comment();
        comment1.SetName("Isabella Garcia");
        comment1.SetText("Your guitar skills are incredible! I aspire to play like you someday.");
        
        Comment comment2 = new Comment();
        comment2.SetName("James Lee");
        comment2.SetText("I've been struggling with certain guitar techniques, but your video tutorial really helped me improve. Thank you!");
        
        Comment comment3 = new Comment();
        comment3.SetName("Sophia Anderson");
        comment3.SetText("The passion and emotion you put into your playing is truly captivating. I could listen to you for hours!");

        Comment comment4 = new Comment();
        comment4.SetName("Liam Wilson");
        comment4.SetText("Your guitar tutorial is so informative and well-explained. I appreciate the effort you put into breaking down complex techniques. Keep up the great work!");

        video.AddComment(comment1);
        video.AddComment(comment2);
        video.AddComment(comment3);
        video.AddComment(comment4);

        _videos.Add(video);
    }
}