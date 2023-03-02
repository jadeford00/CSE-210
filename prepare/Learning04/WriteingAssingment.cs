
public class WritingAssingment : Assignment
{
    public string _title = "";

    public WritingAssingment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string studentName = GetName();
        return $"{_title} by {studentName}";
    }
}