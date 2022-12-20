using System.Numerics;

namespace FactoryPlanner.FactoryTypes.Transport.Belts;

public class RedBelt : IBelt
{
    public double Saturation { get; set; } = 30;
    public Vector2 Position { get; set; }

    public Vector2 Size { get; } = new(1, 1);

    public IPlaceble.Direction Orientation { get; set; }

    public RedBelt(double saturation, Vector2 position, IPlaceble.Direction orientation)
    {
        Saturation = saturation;
        Position = position;
        Orientation = orientation;
    }
}
