using CleanArchitecture_IMS.CoreEntities;

namespace CleanArchitecture_IMS.UseCases.Inventory.Interfaces
{
    public interface IAddInventoryItemUseCase
    {
        Task ExecuteAsync(InventoryItem inventoryItem);
    }
}