namespace HungryNinja;
class Program
{
    static void Main(string[] args)
    {
        Buffet buffet = new();
        Ninja ninja = new();
        ninja.Eat(buffet.Serve());
        ninja.Eat(buffet.Serve());
        ninja.Eat(buffet.Serve());
        ninja.Eat(buffet.Serve());
        ninja.Eat(buffet.Serve());
        ninja.Eat(buffet.Serve());
        // Console.WriteLine(buffet.Serve());
    }
}
