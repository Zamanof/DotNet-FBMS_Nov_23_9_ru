// Events
class Teacher
{
    public event ExamDelegate examEvent;

    public void Exam(string task)
    {
        examEvent(task);
    }
    
}
