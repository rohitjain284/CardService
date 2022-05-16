namespace ClientLibrary.Model
{
    public class BOData
    {
        public long Id { get; set; }
        public string InstitutionId{ get; set; }
        public int CustomerIdentifier { get; set; }
        public string CardIdentifier { get; set; }
        public string MaskedPan { get; set; }
        public string EncryptedPan { get; set; }
        public string CardExpiry { get; set; }
        public string CardLifecycleStatus { get; set; }
        public string CardBlockStatus { get; set; }
        public string CreatedOn { get; set; }
        public string ActivatedOn { get; set; }
        public string DeactivatedOn { get; set; }
    }
}
