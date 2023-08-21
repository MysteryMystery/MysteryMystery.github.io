namespace Blazor.Models.Catan
{
    public class ResourceTile : IBoardTile
    {
        private int _diceValue;

        public int DiceValue {
            get => _diceValue; 
            set {
                if(value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException("Value must be between 1 and 12");
                _diceValue = value;
            }
        }
        public ResourceType ResourceType { get; set; }
    }
}
