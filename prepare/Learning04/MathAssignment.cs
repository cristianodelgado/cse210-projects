public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string Problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = Problems;
    }

    public object GetHomeworkList()
    {
        return " Section" + _textbookSection + "Problems " + _problems;
    }
}