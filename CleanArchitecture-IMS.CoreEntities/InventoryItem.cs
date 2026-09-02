using System.ComponentModel.DataAnnotations; // data annotations are responsible for form validation

namespace CleanArchitecture_IMS.CoreEntities
{
    public class InventoryItem
    {
        public int ItemId { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be at least 0.01.")]
        public double Price { get; set; }
    }
}
