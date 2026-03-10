namespace EnterpriseAssetSystem.Models.Entities
{
    public class AssetAccount
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public decimal Balance { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
