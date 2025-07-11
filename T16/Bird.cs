namespace T16;

public class Bird
{
    public void Fly()
    {
        Console.WriteLine("I can fly!");
    }

    public void LayEggs()
    {
        Console.WriteLine("Laying eggs.");
    }
}

public class Ostrich : Bird
{
    public new void Fly()
    {
        throw new NotSupportedException("Ostriches can't fly!");
    }
}
