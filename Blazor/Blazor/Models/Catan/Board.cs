using System.Runtime.ConstrainedExecution;

namespace Blazor.Models.Catan
{
    public class Board
    {
        public IEnumerable<ResourceTile> Tiles { get; set; }
        public IEnumerable<TradeTile> TradeTiles { get; set; } = new List<TradeTile>();

        public int MaxRowLength { get; } = 7;

        public IEnumerable<IEnumerable<IBoardTile>> TileRows { 
            get {
                List<IBoardTile[]> rows = new();

                var tiles = Tiles.GetEnumerator();
                var tradeTiles = TradeTiles.GetEnumerator();

                int[] rowLengths = new int[] { 4, 5, 6, 7, 6, 5, 4 };

                bool isBorderTileTrade;
                for(int rowLengthId = 0; rowLengthId < rowLengths.Length; rowLengthId++)
                {
                    int rowLength = rowLengths[rowLengthId];
                    IBoardTile[] newRow = new IBoardTile[rowLength];

                    isBorderTileTrade = rowLengthId % 2 == 0;

                    for (int i = 0; i < rowLength; i++)
                    {
                        // add Sea tile if at start of row, end of row or is top/bottom row
                        if (i == 0 || i == rowLength - 1 || rowLengthId == 0 || rowLengthId == rowLengths.Length-1)
                        {
                            if (isBorderTileTrade)
                            {
                                tradeTiles.MoveNext();
                                newRow[i] = tradeTiles.Current;
                            }
                            else 
                                newRow[i] = new SeaTile();

                            isBorderTileTrade = !isBorderTileTrade;
                        }
                        else
                        {
                            tiles.MoveNext();
                            newRow[i] = tiles.Current;
                        }
                    }
                    rows.Add(newRow);
                }

                return rows;
            } 
        }
    }
}
