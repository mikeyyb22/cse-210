using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Bob Dobbs", "Great stuff");
        Comment comment2 = new Comment("Bub Dubbs", "Love it!");
        Comment comment3 = new Comment("Bib Dibbs", "You smell like beans");
        Comment comment4 = new Comment("Bab Dabbs", "You are a funny guy.");
        Comment comment5 = new Comment("Ruth Booth", "Nice.");
        Comment comment6 = new Comment("Craig Tooth", "This stinks");
        Comment comment7 = new Comment("Keith Teeth", "I hate haircuts");
        Comment comment8 = new Comment("ilovebeef", "Nice cut, Hingle!");
        Comment comment9 = new Comment("smeargle33", "bruh");
        Comment comment10 = new Comment("Rad Dan", "this reminds me of a story");
        Comment comment11 = new Comment("Paul the Guy", "Come to Brasil!");
        Comment comment12 = new Comment("justdoodsbeingbros", "I love cereal");

        List<Comment> comments1 = new List<Comment> { comment1, comment2, comment3 };
        List<Comment> comments2 = new List<Comment> { comment4, comment5, comment6 };
        List<Comment> comments3 = new List<Comment> { comment7, comment8, comment9 };
        List<Comment> comments4 = new List<Comment> { comment10, comment11, comment12 };

        Video video1 = new Video("How to cook", "buddy123", 250, comments1);
        Video video2 = new Video("How to fly", "jomama44", 605, comments2);
        Video video3 = new Video("I cut my hair!", "Hingle McCringleberry", 366, comments3);
        Video video4 = new Video("Eating cereal.", "i like chairs", 108, comments4);

        video1.DisplayVideoInfo();
        video2.DisplayVideoInfo();
        video3.DisplayVideoInfo();
        video4.DisplayVideoInfo();
    }
}