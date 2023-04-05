class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "What Not To Do";
        video1._author = "Jade Ford";
        video1._length = "1 Minute 20 Seconds";

        Video video2= new Video();
        video2._title = "How To...";
        video2._author = "John Doe";
        video2._length = "4 Miinutes and 8 Seconds";

        Video video3= new Video();
        video3._title = "Skin Care Routine";
        video3._author = "Jane Doe";
        video3._length = "3 Miinutes and 45 Seconds";


        Comment newComment1 = new Comment();
        newComment1._name = "Mary Bark";
        newComment1._viewerComment = "The editing in this video is really good!";
        newComment1._video.Add(video1);
        newComment1.Display();
        Console.WriteLine();

        
        Comment newComment2 = new Comment();
        newComment2._name = "Keith Walpole";
        newComment2._viewerComment = "Your video helped me out a lot!";
        newComment2._video.Add(video2);
        newComment2.Display();
        Console.WriteLine();


        Comment newComment3 = new Comment();
        newComment3._name = "Aretha Franklin";
        newComment3._viewerComment = "Thanks sis!";
        newComment3._video.Add(video3);
        newComment3.Display();
        Console.WriteLine();
    }
}