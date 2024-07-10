// Subject - Publisher
// Observers - Subscribers

ProductManager productManager = new ProductManager();
var customer = new CustomerObserver();
var employee = new EmployeeObserver();
productManager.Attach(customer);
productManager.Attach(employee);
productManager.UpdatePrice();
productManager.NewCollection();
productManager.Detach(customer);
Console.WriteLine();
productManager.UpdatePrice();
productManager.NewCollection();

abstract class Observer
{
    public abstract void Update(string message);
}

class CustomerObserver : Observer
{
    public override void Update(string message)
    {
        Console.WriteLine($"Message to customer {message}");
    }
}

class EmployeeObserver : Observer
{
    public override void Update(string message)
    {
        Console.WriteLine($"Message to employers {message}");
    }
}

// Publisher
class ProductManager
{
    private List<Observer> _observers = new List<Observer>();

    public void UpdatePrice()
    {
        Notify("Product Price change");
        // Some code about update price
    }
    public void NewCollection()
    {
        // Some code about new collection
        Notify("New Collection");
    }

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }
    public void Detach(Observer observer) 
    {
        _observers.Remove(observer);
    }
    private void Notify(string message)
    {
        foreach (var item in _observers)
        {
            item.Update(message);
        }
    }
}
