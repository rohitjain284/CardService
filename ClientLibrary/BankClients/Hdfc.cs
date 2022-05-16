using ClientLibrary.Contract;
using ClientLibrary.Model;
using System;

namespace ClientLibrary.Clients
{
    public class Hdfc : IClient
    {
        public static string ConnectionString = AppConfiguration.appConfigurationSettings.HDFCConnectionString.ToString();
        public static string ServiceUrl = AppConfiguration.appConfigurationSettings.HDFCServiceUrl.ToString();
        public static string AuthenticationParam = AppConfiguration.appConfigurationSettings.HDFCAuthParams.ToString();
        /// <summary>
        /// Get Card Information
        /// </summary>
        /// <param name="cardIdentifier"></param>
        /// <returns></returns>
        public CardInformation GetCard(string cardIdentifier)
        {
            try
            {
                CardInformation oCard = new CardInformation();
                oCard.CardIdentifier = "EX1234567890123";
                oCard.MaskedPan = "412345******1234";
                oCard.CardLifecycleStatus = "00";
                oCard.CardBlockStatus = "00";
                oCard.CreatedOn = "2022-01-22T14:02:54:947Z";
                oCard.DeactivatedOn = null;
                return oCard;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
