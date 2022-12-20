using FactoryPlanner.FactoryTypes.Modules;
using System.Collections.Generic;

namespace FactoryPlanner.FactoryTypes.Factories;

public interface IFactory : IPlaceble
{
    Recipes.Recipe Recipe { get; }

    double BaseSpeed { get; }

    double SpeedMultiplier { get; set; }

    int LiquidIns { get; }
    int LiquidOuts { get; }

    int ModuleSlots { get; }

    List<IModule> Modules { get; }

    bool IsPowered { get; set; }
}
