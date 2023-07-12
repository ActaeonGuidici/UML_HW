var list = new List<ICanСhargePhone>
{
    new Lightning(),
    new TypeC(),
    new TypeBAdapter()
};

foreach (var item in list)
{
    item.Сharge();
}

interface ICanСhargePhone
{
    void Сharge();
}

class Lightning : ICanСhargePhone
{
    public void Сharge()
    {
        Console.WriteLine("Lightning charge phone");
    }
}


class TypeC : ICanСhargePhone
{
    public void Сharge()
    {
        Console.WriteLine("TypeC charge phone");
    }
}

class TypeB
{
    public void СhargePhone()
    {
        Console.WriteLine("TypeB charge phone");
    }
}

class TypeBAdapter : ICanСhargePhone
{
    private readonly TypeB? typeB = null;
    public TypeBAdapter()
    {
        typeB = new TypeB();
    }
    public void Сharge()
    {
        typeB?.СhargePhone();
    }
}
