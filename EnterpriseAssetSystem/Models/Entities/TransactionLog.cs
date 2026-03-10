namespace EnterpriseAssetSystem.Models.Entities
{
    public class TransactionLog
    {
        public int Id { get; set; }

        public int AssetAccountId { get; set; }

        public decimal Amount { get; set; }

        public string Type { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
