//using System;

//namespace MyApp
//{

//    //Decorator- structural



    //public class Notifier
    //{
    //    public void Send(string message)
    //    {
    //        Console.WriteLine("send message");
    //    }

    //}
    //public abstract class BaseDecorator : Notifier
    //{
    //    private Notifier _wrapee;
    //    public BaseDecorator(Notifier wrapee)
    //    {
    //        _wrapee = wrapee;
    //    }
    //    public void WrapeeSend(string message)
    //    {
    //        Console.WriteLine("send wrapee message");

    //    }

    //}
    //public class SMSDecorator : BaseDecorator
    //{
    //    public SMSDecorator(Notifier wrapee) : base(wrapee)
    //    {
    //    }

    //    public new void Send(string message)
    //    {
    //        Console.WriteLine("send SMS message");

    //    }
    //}
    //public class FBDecorator : BaseDecorator
    //{
    //    public FBDecorator(Notifier wrapee) : base(wrapee)
    //    {
    //    }

    //    public new void Send(string message)
    //    {
    //        Console.WriteLine("send FB message");

    //    }

    //}
    //public class SlackDecorator : BaseDecorator
    //{
    //    public SlackDecorator(Notifier wrapee) : base(wrapee)
    //    {
    //    }

    //    public new void Send(string message)
    //    {
    //        Console.WriteLine("send SLACK message");

    //    }

    //}



    ////Builder-creational
    ///

    //class House
    //{
    //    public string? Name { get; set; }
    //    public int Walls { get; set; }
    //    public int Doors { get; set; }
    //    public int Windows { get; set; }
    //    public bool HasRoof { get; set; }
    //    public bool HasGarage { get; set; }
    //    public bool HasGarden { get; set; }
    //    public bool HasPool { get; set; }

    //}


    //interface IHouseBuilder
    //{
    //    House House { get; set; }

    //    IHouseBuilder BuildWalls(int count);
    //    IHouseBuilder BuildDoors(int count);
    //    IHouseBuilder BuildWindows(int count);
    //    IHouseBuilder BuildRoof();
    //    IHouseBuilder BuildGarage();
    //    IHouseBuilder BuildGarden();
    //    IHouseBuilder BuildPool();

    //    House GetResult();
    //}


    ////Command-Behavioral


    //interface ICommand
    //{
    //    public void Execute();
    //}
    //class SaveCommand : ICommand
    //{
    //    public void Execute()
    //    {
    //        Console.WriteLine("Save Command execute");
    //    }
    //}
    //class OpenCommand : ICommand
    //{
    //    public void Execute()
    //    {
    //        Console.WriteLine("Open Command execute");
    //    }
    //}
    //class PrintCommand : ICommand
    //{
    //    public void Execute()
    //    {
    //        Console.WriteLine("Print Command execute");
    //    }
    //}

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}