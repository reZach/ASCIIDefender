using System;
using System.Collections.Generic;
using System.IO;

namespace ASCIIDefender.Utilities
{
    public class MapLoader
    {
        public MapLoadResult Load(string path)
        {
            MapLoadResult mapLoadResult = new MapLoadResult();

            try
            {
                string line = string.Empty;
                List<string> rows = new List<string>();

                // Read map from file
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!string.IsNullOrEmpty(line = sr.ReadLine()))
                    {
                        rows.Add(line);
                    }
                }

                // Parse map into object
                if (rows.Count > 0)
                {
                    mapLoadResult.Map = new char[rows[0].Length, rows.Count];
                    for (int j = 0; j < rows.Count; j++)
                    {
                        for (int i = 0; i < rows[j].Length; i++)
                        {
                            mapLoadResult.Map[i, j] = rows[j][i];
                        }
                    }
                }

                mapLoadResult.Success = true;
            }
            catch (Exception ex)
            {
                mapLoadResult.Error = ex.Message;
            }

            return mapLoadResult;
        }
    }

    public class MapLoadResult
    {
        public char[,] Map { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }
}
