using System.Globalization;

namespace Dictionary;

abstract public class LIONS
{
    public LIONS()
    {

    }
    public abstract void eating();

    void sleeping()
    {
        
        Console.WriteLine("Hello From Cesar");
        Console.WriteLine("LIONS sleeping");
    }
}

sealed public class TIGERS : LIONS
{
    public override void eating()
    {
        Console.WriteLine(" And TIGERS eating");
    }
     void sleeping() => Console.WriteLine("TIGERS sleeping");
}
