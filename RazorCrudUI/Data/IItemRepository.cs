using NuGet.Configuration;
using RazorCrudUI.Models;

namespace RazorRepoUI.Data
{
    public interface IItemRepository
    {
        IEnumerable<ItemModel> GetItems();
        IEnumerable<ItemModel> GetItems(string filter);

        ItemModel? GetItemByID(int id);

        void insertItem(ItemModel item);

        string deleteItem(int id);

        bool updateItem(ItemModel item);

    }
}
