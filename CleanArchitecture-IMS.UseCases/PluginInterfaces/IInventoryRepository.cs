using CleanArchitecture_IMS.CoreEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture_IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync();
    }
}
