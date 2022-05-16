using System;
using ClientLibrary.Clients;
using ClientLibrary.Contract;


namespace ClientLibrary
{
    public class GetClientData : IClientData
    {
        /// <summary>
        /// Get client instance by instituion id 
        /// </summary>
        /// <param name="instituionId"></param>
        /// <returns></returns>
        public IClient GetClientInstance(string instituionId)
        {
            try
            {
                switch (instituionId)
                {
                    case "9163":
                        return new Hdfc();
                    case "9164":
                        return new Icici();
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
