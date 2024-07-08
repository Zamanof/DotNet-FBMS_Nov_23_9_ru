Application application = new Application(new JSONSerialization());
application.CRUD();


#region Dependency Inversion Bad example
//class MsSQL
//{
//    public void Create() => Console.WriteLine("Create with MS SQL");
//    public void Read() => Console.WriteLine("Read with MS SQL");
//    public void Update() => Console.WriteLine("Update with MS SQL");
//    public void Delete() => Console.WriteLine("Delete with MS SQL");
//}

//class MySQL
//{
//    public void Create() => Console.WriteLine("Create with MySQL");
//    public void Read() => Console.WriteLine("Read with MySQL");
//    public void Update() => Console.WriteLine("Update with MySQL");
//    public void Delete() => Console.WriteLine("Delete with MySQL");
//}

//class Postgree
//{
//    public void Create() => Console.WriteLine("Create with Postgree");
//    public void Read() => Console.WriteLine("Read with Postgree");
//    public void Update() => Console.WriteLine("Update with Postgree");
//    public void Delete() => Console.WriteLine("Delete with Postgree");
//}

//class Application
//{
//    private Postgree _db;

//    public Application(Postgree db)
//    {
//        _db = db;
//    }

//    public void CRUD()
//    {
//        _db.Create();
//        _db.Read();
//        _db.Update();
//        _db.Delete();
//    }
//}
#endregion

#region Dependency Inversion Good example

// Abstraksiya
interface IDb
{
    void Create();
    void Read();
    void Update();
    void Delete();
}
// Modul nijneqo urovnya
class MsSQL : IDb
{
    public void Create() => Console.WriteLine("Create with MS SQL");
    public void Read() => Console.WriteLine("Read with MS SQL");
    public void Update() => Console.WriteLine("Update with MS SQL");
    public void Delete() => Console.WriteLine("Delete with MS SQL");
}

// Modul nijneqo urovnya
class MySQL : IDb
{
    public void Create() => Console.WriteLine("Create with MySQL");
    public void Read() => Console.WriteLine("Read with MySQL");
    public void Update() => Console.WriteLine("Update with MySQL");
    public void Delete() => Console.WriteLine("Delete with MySQL");
}

// Modul nijneqo urovnya
class Postgree : IDb
{
    public void Create() => Console.WriteLine("Create with Postgree");
    public void Read() => Console.WriteLine("Read with Postgree");
    public void Update() => Console.WriteLine("Update with Postgree");
    public void Delete() => Console.WriteLine("Delete with Postgree");
}

// Modul nijneqo urovnya
class JSONSerialization : IDb
{
    public void Create() => Console.WriteLine("Create with JSONSerialization");
    public void Read() => Console.WriteLine("Read with JSONSerialization");
    public void Update() => Console.WriteLine("Update with JSONSerialization");
    public void Delete() => Console.WriteLine("Delete with JSONSerialization");
}

// Modul verxneqo urovnya
class Application
{
    private IDb _db;

    public Application(IDb db)
    {
        _db = db;
    }

    public void CRUD()
    {
        _db.Create();
        _db.Read();
        _db.Update();
        _db.Delete();
    }
}
#endregion

