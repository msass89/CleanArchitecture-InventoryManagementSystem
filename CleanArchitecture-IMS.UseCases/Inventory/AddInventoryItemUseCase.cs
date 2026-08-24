using CleanArchitecture_IMS.CoreEntities;
using CleanArchitecture_IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
