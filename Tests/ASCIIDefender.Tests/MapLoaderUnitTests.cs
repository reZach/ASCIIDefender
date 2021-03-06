using ASCIIDefender.Utilities;
using Xunit;

namespace ASCIIDefender.Tests
{
    public class MapLoaderUnitTests
    {
        [Fact]
        public void QueryMaps_Is_Success()
        {
            // arrange
            MapLoader mapLoader = new MapLoader();

            // act
            MapQueryResult mapLoadResult = mapLoader.Query();

            // assert
            Assert.True(mapLoadResult.Success);
            Assert.Null(mapLoadResult.Error);
            Assert.NotEmpty(mapLoadResult.Maps);
        }

        [Fact]
        public void LoadMap_Is_Success()
        {
            // arrange
            MapLoader mapLoader = new MapLoader();

            // act
            MapLoadResult mapLoadResult = mapLoader.Load("./Maps/loadmaptest.txt");

            // assert
            Assert.True(mapLoadResult.Success);
            Assert.Null(mapLoadResult.Error);
            Assert.Equal(' ', mapLoadResult.Map[0, 0]);
            Assert.Equal('W', mapLoadResult.Map[3, 0]);
            Assert.Equal('O', mapLoadResult.Map[2, 3]);
        }
    }
}
