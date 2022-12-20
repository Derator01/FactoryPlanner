using FactoryPlanner.FactoryTypes.Modules;
using FactoryPlanner.FactoryTypes.Recipes;
using System.Collections.Generic;
using System.Numerics;

namespace FactoryPlanner.FactoryTypes.Factories;

public class FactoryBlue : IFactory
{
    public Recipe Recipe { get; }

    public double BaseSpeed { get; } = 0.75;

    public double SpeedMultiplier { get; set; }

    public int LiquidIns { get; }

    public int LiquidOuts { get; } = 0;

    public int ModuleSlots { get; } = 2;

    public List<IModule> Modules { get; } = new List<IModule>();

    public bool IsPowered { get; set; } = false;
    public double Saturation { get; set; }
    public Vector2 Position { get; set; }

    public Vector2 Size { get; } = new(3, 3);

    public IPlaceble.Direction Orientation { get; set; }

    public FactoryBlue(Recipe recipe, double speedMultiplier, List<IModule> modules, int saturation, Vector2 position,IPlaceble.Direction orientation)
    {
        Recipe = recipe;
        SpeedMultiplier = speedMultiplier;
        Modules = modules;
        Saturation = saturation;
        Position = position;
        Orientation = orientation;

        LiquidIns = recipe.LiquidIn;
    }
}
