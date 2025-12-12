class HondaFactory : ACarFactory
{
    public override ICar MakeCar(string model, string colour)
    {
        return new Honda(model, colour);
    }
} //class HondaFactory

class BMWFactory : ACarFactory
{
    public override ICar MakeCar(string model, string colour)
    {
        return new BMW(model, colour);
    }
} //class BMWFactory
