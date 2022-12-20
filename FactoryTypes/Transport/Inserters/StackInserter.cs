using System.Numerics;

namespace FactoryPlanner.FactoryTypes.Transport.Inserters;

public class StackInserter : IInserter
{
    public double Speed { get; } = 12;

    public int Distance { get; } = 1;

    public int Capacity { get; } = 5;

    public double Saturation { get; set; }
    public Vector2 Position { get; set; }

    public Vector2 Size { get; } = new(1, 1);

    public IPlaceble.Direction Orientation { get; set; }
}
