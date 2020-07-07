using ASCIIDefender.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIDefender.Main
{
    public class Driver
    {
        private readonly Board _board;
        private readonly MapLoader _mapLoader;

        public Driver()
        {
            _board = new Board();
            _mapLoader = new MapLoader();
        }

        public void GameLoop()
        {
            // Menu
            Console.WriteLine("Pick a map:");
            Console.WriteLine("");

            MapQueryResult mapQueryResult = _mapLoader.Query();
            for (int i = 0; i < mapQueryResult.Maps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {mapQueryResult.Maps[i]}");
            }
            Console.Write("> ");

            bool success = Int32.TryParse(Console.ReadLine(), out int input);
            if (success)
            {

            }
        }
    }
}
