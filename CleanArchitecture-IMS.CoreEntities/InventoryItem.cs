namespace CleanArchitecture_IMS.CoreEntities
{
    public class InventoryItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
