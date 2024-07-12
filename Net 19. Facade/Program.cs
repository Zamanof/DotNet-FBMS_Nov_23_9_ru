// Facade pattern

ComputerFacade facade = new ComputerFacade();
facade.Start();

interface IDevice
{
    string? Vendor { get; set; }
    string? Model { get; set; }
    void Start();
}

class CPU: IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("CPU Started");
    }
}

class RAM: IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("RAM Started");
    }
}

class GPU : IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("GPU Started");
    }
}

class MotherBoard : IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("MotherBoard Started");
    }
}

class PowerSupply : IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("PowerSupply Started");
    }
}

class Case : IDevice
{
    private List<IDevice> Devices { get; set; } = new();
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Devices.ForEach(x => x.Start());
        Console.WriteLine("PC started");
    }

    public void AddDevice(IDevice device)
    {
        Devices.Add(device);
    }
}

class ComputerFacade
{
    private MotherBoard mb = new MotherBoard();
    private RAM ram = new RAM();
    private CPU cpu = new CPU();
    private GPU gpu = new GPU();
    private PowerSupply powerSupply = new PowerSupply();
    private Case pcCase = new Case();

    public void Start()
    {
        pcCase.AddDevice(mb);
        pcCase.AddDevice(ram);
        pcCase.AddDevice(cpu);
        pcCase.AddDevice(gpu);
        pcCase.AddDevice(powerSupply);

        pcCase.Start();
    }
}
