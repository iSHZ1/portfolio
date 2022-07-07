namespace ActManager;

public class Program
{
    public static void Main()
    {
        var engine = new ActEngine();
        var act = engine.CreateAct();

        Console.WriteLine(act?.Id);
    }
}
