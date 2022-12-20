namespace FactoryPlanner.FactoryTypes.Modules;

public interface IModule
{
    Type ModuleType { get; }

    double SpeedProcentage { get; }
    double EfficiencyProcentage { get; }
    double ProductivityProcentage { get; }

    enum Type
    {
        Speed,
        Efficiency,
        Productivity
    }
}
