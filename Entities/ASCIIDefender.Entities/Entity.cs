using System;

namespace ASCIIDefender.Entities
{
    public abstract class Entity
    {
        public EntityId Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public char Icon { get; set; }
        public bool Obstacle { get; set; }
        public bool SeeThrough { get; set; }

        public ConsoleColor ForegroundColor { get; set; } = ConsoleColor.Black;
        public ConsoleColor BackgroundColor { get; set; } = ConsoleColor.White;
    }

    public enum EntityId
    {
        Player,
        Castle,
        Wall,
        Hole
    }
}
