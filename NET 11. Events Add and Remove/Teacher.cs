namespace NET_11._Events_Add_and_Remove;

internal class Teacher
{

    SortedList<int, ExamDelegate> _sortedEvents 
        = new SortedList<int, ExamDelegate>();
    Random _random = new Random();

    public event ExamDelegate examEvent
    {
        add {
            for (int key = 0;;)
            {
                key = _random.Next();
                if (!_sortedEvents.ContainsKey(key))
                {
                    _sortedEvents.Add(key, value);
                    break;
                }
            }
        }
        remove 
        {
            _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
        }
    }

    public void Exam(string task)
    {
        foreach (int key in _sortedEvents.Keys)
        {
            if (_sortedEvents[key] is not null)
            {
                _sortedEvents[key].Invoke(task);
            }
        }
    }
}


