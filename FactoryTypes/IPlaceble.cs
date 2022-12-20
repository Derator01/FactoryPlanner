using System.Numerics;

namespace FactoryPlanner.FactoryTypes;

public interface IPlaceble
{
    double Saturation { get; set; }

    Vector2 Position { get; set; }
    Vector2 Size { get; }

    Direction Orientation { get; set; }

    enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        Ambigious
    }
}
