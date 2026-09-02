using CleanArchitecture_IMS.CoreEntities;

namespace CleanArchitecture_IMS.UseCases.Inventory.Interfaces
{
    public interface IViewInventoryItemsByNameUseCase
    {
        Task<IEnumerable<InventoryItem>> ExecuteAsync(string name = "");
    }
}