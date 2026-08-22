using CleanArchitecture_IMS.CoreEntities;
using CleanArchitecture_IMS.UseCases.PluginInterfaces;


namespace CleanArchitecture_IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<InventoryItem> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<InventoryItem>()
            {
                new InventoryItem { ItemId = 1, ItemName = "Motor", Quantity = 12, Price = 400},
                new InventoryItem { ItemId = 2, ItemName = "Coupling", Quantity = 52, Price = 60},
                new InventoryItem { ItemId = 3, ItemName = "Shaft", Quantity = 34, Price = 45},
                new InventoryItem { ItemId = 4, ItemName = "Impeller", Quantity = 20, Price = 24},
                new InventoryItem { ItemId = 4, ItemName = "Casing", Quantity = 14, Price = 200},
                new InventoryItem { ItemId = 4, ItemName = "Centrifugal Pump", Quantity = 27, Price = 2200}
            };
        }

        public async Task<IEnumerable<InventoryItem>> GetInventoryItemsByNameAsync(string name)
        {
            // returns the whole Inventory, if the name is empty or white space
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            // if the name is not empty, returns inventory items by name
            return _inventories.Where(x => x.ItemName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
