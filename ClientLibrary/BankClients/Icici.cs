using ClientLibrary.Contract;
using ClientLibrary.Model;
using System;

namespace ClientLibrary.Clients
{
    public class Icici : IClient
    {
        public static string ConnectionString = AppConfiguration.appConfigurationSettings.IciciConnectionString.ToString();
        public static string ServiceUrl = AppConfiguration.appConfigurationSettings.IciciServiceUrl.ToString();
        public static string AuthenticationParam = AppConfiguration.appConfigurationSettings.IciciAuthParams.ToString();
        /// <summary>
        /// Get Card Infomation 
        /// </summary>
        /// <param name="cardIdentifier"></param>
        /// <returns></returns>
        public CardInformation GetCard(string cardIdentifier)
        {
            try
            {
                CardInformation oCard = new CardInformation();
                oCard.CardIdentifier = "EX1234567890125";
                oCard.MaskedPan = "412345******1235";
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
