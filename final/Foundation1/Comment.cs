public class Comment
{
    public string _name;
    public string _viewerComment;

        public List<Video> _video = new List<Video>();

    public void Display()
    {
            foreach (Video video in _video)
        {
            video.Display();
        }

        Console.WriteLine($"Comment: {_viewerComment}");
        Console.WriteLine($"Commenter's Name: {_name}");
    }
}