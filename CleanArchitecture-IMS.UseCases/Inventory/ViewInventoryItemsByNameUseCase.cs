using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture_IMS.CoreEntities;
using CleanArchitecture_IMS.UseCases.Inventories.Interfaces;
using CleanArchitecture_IMS.UseCases.PluginInterfaces;


namespace CleanArchitecture_IMS.UseCases.Inventories
{
    public class ViewInventoryItemsByNameUseCase : IViewInventoryItemsByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        // type of dependency injection: constructor dependency injection
        public ViewInventoryItemsByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<InventoryItem>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoryItemsByNameAsync(name);
        }
    }
}
