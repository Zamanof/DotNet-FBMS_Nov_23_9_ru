using NET_09._Interfaces.Concrete_classes;

// Interface

// Наследование от классов (обычных, абстрактных)
// это отношение "является" (is)

// Реализация интерфейсов это в основном "умеет" (can do)


// От классов наследуются
// Интерфейсы реализуют


// Интерфейс это "контракт" который надо соблюдать

// Интерфейсная ссылка

IWalk[] walks = new IWalk[]
{
    new Teacher(),
    new Cat()
};

IThink[] thinks = new IThink[]
{
    new Teacher(),
    new Cat()
};


Foo(thinks[0]);
Foo(thinks[1]);

void Foo(IThink think)
{
    think.Think();
}

