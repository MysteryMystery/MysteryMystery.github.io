namespace Blazor.Models.Catan
{
    public class TradeTile : IBoardTile
    {
        public int OfferValue { get => OfferResourceType == ResourceType.WILDCARD ? 3 : 2; }

        public ResourceType OfferResourceType { 
            get; 
            set; 
        }
    }
}
