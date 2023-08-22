using Blazor.Models.Catan;
using Blazor.Services.Catan;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Catan.Tests
{
    internal class BoardBuildingTests
    {
        private ICatanBoardBuilder _catanBoardBuilder;
        private ILogger<CatanBoardBuilder> _logger;

        [SetUp]
        public void Setup()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();
            var factory = serviceProvider.GetService<ILoggerFactory>();

            _logger = factory.CreateLogger<CatanBoardBuilder>();
            _catanBoardBuilder = new CatanBoardBuilder(_logger);
        }

        [Test]
        public void GenerateBoard()
        {
            var board = _catanBoardBuilder.Random().Result;

            Assert.IsTrue(board.Tiles.Count(x => x.ResourceType == ResourceType.DESERT) == 1);
            Assert.IsTrue(board.Tiles.Count(x => x.ResourceType == ResourceType.BRICK) == 3);
            Assert.IsTrue(board.Tiles.Count(x => x.ResourceType == ResourceType.ORE) == 3);
            Assert.IsTrue(board.Tiles.Count(x => x.ResourceType == ResourceType.WOOD) == 4);
            Assert.IsTrue(board.Tiles.Count(x => x.ResourceType == ResourceType.WHEAT) == 4);
            Assert.IsTrue(board.Tiles.Count(x => x.ResourceType == ResourceType.SHEEP) == 4);
            Assert.IsTrue(board.TradeTiles.Count() == 9);
        }

        [Test]
        public void GetTileRows()
        {
            var board = _catanBoardBuilder.Random().Result;
            var rows = board.TileRows;
            Assert.Pass();
        }
    }
}
