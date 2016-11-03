using System;
namespace TreehouseDefense
{
    class PowerfulTower : Tower
    {
        protected override int Power { get; } = 3;

        public PowerfulTower(MapLocation location) : base(location)
        {
        }
    }
}