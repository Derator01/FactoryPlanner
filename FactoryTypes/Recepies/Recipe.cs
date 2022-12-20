using System.Collections.Generic;

namespace FactoryPlanner.FactoryTypes.Recipes;

public class Recipe
{
    public string Name { get; }

    public double CraftingTime { get; }

    public List<Throughput> Outputs { get; }

    public List<Throughput> Inputs { get; }

    public int LiquidIn { get; private set; }
    public int LiquidsOut { get; private set; }

    public Recipe(string name, double craftingTime, List<Throughput> outputs, List<Throughput> inputs, int hasLiquidsIn, int liquidsOut)
    {
        Name = name;
        CraftingTime = craftingTime;
        Outputs = outputs;
        Inputs = inputs;
        LiquidIn = hasLiquidsIn;
        LiquidsOut = liquidsOut;
    }

    public static Recipe Parse(string toParse)
    {
        string[] parameters = toParse.Split('|');

        return new Recipe(parameters[0], double.Parse(parameters[1]), ParseThroughput(parameters[2]), ParseThroughput(parameters[3]), int.Parse(parameters[4]), int.Parse(parameters[5]);
    }

    private static List<Throughput> ParseThroughput(string toParse)
    {
        string[] parameters = toParse.Split(',');

        List<Throughput> output = new();

        for (int i = 0; i < parameters.Length; i++)
            output.Add(new(parameters[i]));

        return output;
    }
}
