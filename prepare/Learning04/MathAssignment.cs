public class MathAssignment : Assignment
{
    private string _homeworkList;
    private string _problems;
    public MathAssignment(string studentName, string topic, string homeworkList, string Problems)
        : base(studentName, topic)
    {
        _homeworkList = homeworkList;
        _problems = Problems;
    }

    public object GetHomeworkList()
    {
        return " Section" + _homeworkList + "Problems " + _problems;
    }
}