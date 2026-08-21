using CleanArchitecture_IMS.CoreEntities;
using CleanArchitecture_IMS.UseCases.PluginInterfaces;

namespace CleanArchitecture_IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory { InventoryId = 1, InventoryName = "Motor", Quantity = 12, Price = 400},
                new Inventory { InventoryId = 2, InventoryName = "Coupling", Quantity = 52, Price = 60},
                new Inventory { InventoryId = 3, InventoryName = "Shaft", Quantity = 34, Price = 45},
                new Inventory { InventoryId = 4, InventoryName = "Impeller", Quantity = 20, Price = 24},
                new Inventory { InventoryId = 4, InventoryName = "Casing", Quantity = 14, Price = 200},
                new Inventory { InventoryId = 4, InventoryName = "Centrifugal Pump", Quantity = 27, Price = 2200}
            };
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            // returns the whole Inventory, if the name is empty or white space
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            // if the name is not empty, returns inventory items by name
            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
