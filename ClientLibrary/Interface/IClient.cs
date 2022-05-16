using ClientLibrary.Model;

namespace ClientLibrary.Contract
{
    public interface IClient
    {
        CardInformation GetCard(string cardIdentifier);
    }
}
