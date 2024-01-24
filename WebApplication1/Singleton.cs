public class Singleton
{
    private Scoped _scoped;
    private Transient _transient;

    public Singleton(Scoped scoped, Transient transient)
    {
        _scoped = scoped;
        _transient = transient;
        Console.WriteLine("Singleton");
    }
}

public class Scoped
{
    private static int i = 0;
    private Transient _transient;

    public Scoped(Transient transient)
    {
        _transient = transient;
        Console.WriteLine("Scoped {0}", i);
    }
}

public class Transient
{
    private static int i = 0;

    public Transient()
    {
        Console.WriteLine("Transient {0}", i++);

    }
}