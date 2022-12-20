namespace FactoryPlanner.FactoryTypes.Transport.Inserters;

public interface IInserter : IPlaceble
{
    double Speed { get; }

    int Distance { get; }

    int Capacity { get; }
}
