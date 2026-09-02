using CleanArchitecture_IMS.CoreEntities;
using CleanArchitecture_IMS.UseCases.Inventory.Interfaces;
using CleanArchitecture_IMS.UseCases.PluginInterfaces;

namespace CleanArchitecture_IMS.UseCases.Inventory
{
    public class AddInventoryItemUseCase : IAddInventoryItemUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public AddInventoryItemUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(InventoryItem inventoryItem)
        {
            await this.inventoryRepository.AddInventoryItem(inventoryItem);
        }
    }
}
