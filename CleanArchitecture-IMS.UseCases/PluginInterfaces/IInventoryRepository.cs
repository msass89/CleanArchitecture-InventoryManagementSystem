using CleanArchitecture_IMS.CoreEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task AddInventoryItem(InventoryItem inventoryItem);
        Task<IEnumerable<InventoryItem>> GetInventoryItemsByNameAsync(string name);
    }
}
