using ASCIIDefender.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIDefender.Main
{
    public class Board
    {
        public int BorderX { get; set; } = Console.WindowWidth;
        public int BorderY { get; set; } = Console.WindowHeight;
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        private readonly List<Entity> _entities;
        private readonly int _playerIndex;

        public Board()
        {
            MaxX = BorderX - 2;
            MaxY = BorderY - 2;

            _entities = new List<Entity>
            {
                new Player
                {
                    Id = EntityId.Player,
                    X = 0,
                    Y = 0
                }
            };
            _playerIndex = 0;
        }
    }
}
