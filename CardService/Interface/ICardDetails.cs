using ClientLibrary.Model;

namespace CardService.Contract
{
    public interface ICardDetails
    {
        CardInformation GetCard(string instituionId, string cardIdentifier);
    }
}
