
namespace Dota2.Domain.Interfaces
{
    interface IUnitBuilder
    {
        void SetName(string name);
        IUnit Build();
    }
}
