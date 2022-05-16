namespace ClientLibrary.Model
{
    public class CardInformation
    {
        public string CardIdentifier { get; set; }
        public string MaskedPan { get; set; }
        public string CardLifecycleStatus { get; set; }
        public string CardBlockStatus { get; set; }
        public string CreatedOn { get; set; }
        public string DeactivatedOn { get; set; }
    }
}
