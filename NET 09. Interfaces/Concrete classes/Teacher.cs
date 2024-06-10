
// Interface

// Наследование от классов (обычных, абстрактных)
// это отношение "является" (is)

// Реализация интерфейсов это в основном "умеет" (can do)


// От классов наследуются
// Интерфейсы реализуют


// Интерфейс это "контракт" который надо соблюдать
class Teacher : Human, IWalk, IThink, ITeach
{
    public void Teach()
    {
        Console.WriteLine("I can teach") ;
    }

    public void Think()
    {
        Console.WriteLine("I think like Human");
    }

    public void Walk()
    {
        Console.WriteLine("I have two legs. And I Walk");
    }
}



