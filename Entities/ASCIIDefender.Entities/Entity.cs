using System;

namespace ASCIIDefender.Entities
{
    public abstract class Entity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Icon { get; set; }
        public ConsoleColor ForegroundColor { get; set; } = ConsoleColor.Black;
        public ConsoleColor BackgroundColor { get; set; } = ConsoleColor.White;
    }
}
