using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture_IMS.CoreEntities;
using CleanArchitecture_IMS.UseCases.PluginInterfaces;


namespace CleanArchitecture_IMS.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        { 
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoriesByNameAsync();
        }
    }
}
