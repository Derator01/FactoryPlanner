namespace FactoryPlanner.FactoryTypes.Recipes;

public class Throughput
{
    public readonly string Item;

    public readonly int Count;

    public Throughput(string item, int count)
    {
        Item = item;
        Count = count;
    }

    public Throughput(string toParse)
    {
        string[] parameters = toParse.Split(' ');

        Item = parameters[0];
        Count = int.Parse(parameters[1]);
    }
}