using System;
using CardService.Contract;
using ClientLibrary;
using ClientLibrary.Contract;
using ClientLibrary.Model;

namespace CardService
{
    public class CardDetails : ICardDetails
    {
        /// <summary>
        /// Method to get Card Details
        /// </summary>
        /// <param name="instituionId"></param>
        /// <param name="cardIdentifier"></param>
        /// <returns></returns>
        public CardInformation GetCard(string instituionId, string cardIdentifier)
        {
            try
            {
                GetClientData oGetClient = new GetClientData();
                IClient oClient = oGetClient.GetClientInstance(instituionId);
                if (oClient == null)
                {
                    throw new Exception("Invalid Institution Id!");
                }

                return oClient.GetCard(cardIdentifier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
