namespace FactoryPlanner.FactoryTypes.Modules;

public class SpeedModuleFirst : IModule
{
    public IModule.Type ModuleType { get; } = IModule.Type.Speed;

    public double SpeedProcentage { get; } = 20;

    public double EfficiencyProcentage { get; } = -50;

    public double ProductivityProcentage { get; } = 0;
}
