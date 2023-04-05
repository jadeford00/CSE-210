public class Video
{
    public string _title = "";
    public string _author = "";
    public string _length = "";

    public void Display()
    {
      Console.WriteLine($"{_title}, {_author} -- {_length}");
    }
}