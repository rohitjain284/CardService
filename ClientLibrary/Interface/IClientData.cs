namespace ClientLibrary.Contract
{
    public interface IClientData
    {
        IClient GetClientInstance(string instituionId);
    }
}