using System.Data;

namespace InventoryManager.Core.Interfaces
{
    public interface IDataAccessService
    {
        void AddLinkedPart(int productId, int partId);
        void AddPart(Part part);
        void AddProduct(Product product);
        void DeleteLinkedPart(int id);
        void DeletePart(int id);
        void DeleteProduct(int id);
        DataTable GetDataFromTable(string tableName);
        List<ProductPart> GetProductParts(int productId);
        Part? GetPart(int partId);
        void UpdatePart(Part part);
        void UpdateProduct(Product product);
    }
}
