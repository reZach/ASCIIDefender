using System;
using System.Collections.Generic;
using System.IO;

namespace ASCIIDefender.Utilities
{
    public class MapLoader
    {
        public MapQueryResult Query()
        {
            MapQueryResult mapQueryResult = new MapQueryResult();

            try
            {
                string[] directoryInfo = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt", SearchOption.AllDirectories);
                
                mapQueryResult.Maps = directoryInfo;
                mapQueryResult.Success = true;
            }
            catch (Exception ex)
            {
                mapQueryResult.Error = ex.Message;
            }

            return mapQueryResult;
        }

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

    public class MapQueryResult : Result
    {
        public string[] Maps { get; set; }
    }

    public class MapLoadResult : Result
    {
        public char[,] Map { get; set; }
    }
}
