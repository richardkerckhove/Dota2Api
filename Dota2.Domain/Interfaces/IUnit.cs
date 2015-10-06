using Dota2.Domain.Qualities;

namespace Dota2.Domain.Interfaces
{
    public interface IUnit
    {
        string Name { get; }
        UnitType UType { get; }
    }
}