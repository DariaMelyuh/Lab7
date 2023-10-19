

using Лаб7__Мост_;

class Program
{
    static void Main()
    {
        IImplementor conditioner = new AirConditioner();
        MemoryRemote remote = new MemoryRemote(conditioner);

        remote.TurnOn();
        remote.PowerPlus();
        remote.ModeNext();
        remote.Save(1);
        Console.WriteLine();
        remote.PowerMinus();
        remote.ModePreview();
        remote.Save(2);
        Console.WriteLine();
        remote.Load(1);
        Console.WriteLine();
        remote.Load(2);
        Console.WriteLine();
        remote.TurnOff();
        Console.ReadLine();
    }
}
