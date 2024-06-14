namespace Net_11._EventArgs;

internal class Teacher
{
    public string? FirstName {  get; set; }
    public EventHandler<ExamEventArgs> examEvent;
    public void Exam(ExamEventArgs args)
    {
        examEvent(this, args);
    }
}
