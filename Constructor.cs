//https://msdn.microsoft.com/zh-cn/library/ms173115.aspx
public class Taxi
{
    public bool isInitialized;
    
    public Taxi()
    {
        isInitialized = true;
    }
    
    
    
}


class TestTaxi
{
    static void Main()
    {
        Taxi t = new Taxi();
        Console.WriteLine(t.isInitialized);
    }
}
