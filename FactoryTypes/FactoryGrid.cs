using FactoryPlanner.FactoryTypes.Recipes;
using FactoryPlanner.FactoryTypes.Transport.Belts;
using System.Collections.Generic;
using System.Numerics;

namespace FactoryPlanner.FactoryTypes;

public class FactoryGrid
{
    public int FactoryCount { get; private set; }
    public int ConveyorCount { get; private set; }
    public int InserterCount { get; private set; }
    public int ModuleCount { get; private set; }

    private Recipe _recipe;
    private double _speed;
    private IBelt _belt;
    private Vector2 _constraints;
    private Vector2 _outputPos;

    public readonly List<IPlaceble> _map;

    private FactoryGrid(Recipe recipe, double speed, IBelt belt, Vector2 constraints, Vector2 outputPos)
    {
        _recipe = recipe;
        _speed = speed;
        _belt = belt;
        _constraints = constraints;
        _outputPos = outputPos;

        Calculate();
    }

    private void Calculate()
    {
        if (_belt.Speed >= _speed)
        {
            _map[0] = new(_speed, _outputPos, IPlaceble.Direction.Ambigious);
        }
        else
        {
            double beltCount = _speed / _belt.Speed;

            for (int i = 0; i < beltCount; i++)
            {
                _map.Add(new )
            }
        }
    }
}
