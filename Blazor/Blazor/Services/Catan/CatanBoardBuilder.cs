using Blazor.Models.Catan;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Blazor.Services.Catan
{
    public class CatanBoardBuilder : ICatanBoardBuilder
    {
        private readonly ILogger _logger;
        private readonly int MIN_ROLL = 2;
        private readonly int MAX_ROLL = 12;

        public CatanBoardBuilder(ILogger<CatanBoardBuilder> logger)
        {
            _logger = logger;
        }

        public Task<Board> Random()
        {
            _logger.LogInformation("Calling CatanBoardBuilder.Random()");

            Dictionary<ResourceType, int> tileCounts = new()
            {
                { ResourceType.DESERT, 1 },
                { ResourceType.BRICK, 3 },
                { ResourceType.ORE, 3},
                { ResourceType.WOOD, 4},
                { ResourceType.WHEAT, 4},
                { ResourceType.SHEEP, 4},
            };

            Dictionary<int, int> numbersCounts = new();

            List<ResourceTile> tiles = new List<ResourceTile>();

            Random random = new();

            foreach(KeyValuePair<ResourceType, int> tileCount in tileCounts)
            {
                for(int i = 0; i < tileCount.Value; i++)
                {
                    int diceRoll = tileCount.Key == ResourceType.DESERT ? 7 : random.Next(MAX_ROLL - MIN_ROLL + 1) + MIN_ROLL;
                    while ((tileCount.Key != ResourceType.DESERT && diceRoll == 7) || (numbersCounts.ContainsKey(diceRoll) && numbersCounts[diceRoll] == 2))
                    {
                        diceRoll = random.Next(MAX_ROLL - MIN_ROLL + 1) + MIN_ROLL;
                    }

                    tiles.Add(new ResourceTile
                    {
                        DiceValue = diceRoll,
                        ResourceType = tileCount.Key,
                    });

                    // handle the tracking states
                    if (!numbersCounts.ContainsKey(diceRoll))
                        numbersCounts[diceRoll] = 1;
                    else
                        numbersCounts[diceRoll]++;
                }
            }

            _logger.LogInformation(JsonSerializer.Serialize(tiles));

            Array resourceValues = Enum.GetValues(typeof(ResourceType));
            List<TradeTile> tradeTiles = new TradeTile[9].ToList()
                .Select(x => new TradeTile { OfferResourceType = (ResourceType)resourceValues.GetValue(random.Next(resourceValues.Length)) })
                .ToList();

            return Task.FromResult(new Board
            {
                Tiles = tiles.OrderBy(x => random.Next()),
                TradeTiles = GetRandomTradeTiles() //just completely random for now, excluding desert and max 2 duplicates
            }); 
        }

        private TradeTile[] GetRandomTradeTiles()
        {
            TradeTile[] tradeTiles = new TradeTile[9];

            Dictionary<string, int> counts = new();

            List<String> types = Enum.GetNames(typeof(ResourceType)).ToList();
            types.Remove("DESERT");

            Random random = new();
            for(int i = 0; i < tradeTiles.Length; i++) {
                string t;
                do
                {
                     t = types[random.Next(types.Count)];
                }
                while (counts.ContainsKey(t) && counts[t] == 2);

                if (!counts.ContainsKey(t))
                    counts[t] = 1;
                else 
                    counts[t]++;

                tradeTiles[i] = new TradeTile
                {
                    OfferResourceType = (ResourceType) Enum.Parse(typeof(ResourceType), t)
                };
            }

            return tradeTiles;
        }
    }
}
