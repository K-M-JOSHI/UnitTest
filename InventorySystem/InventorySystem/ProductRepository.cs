using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class ProductRepository
    {
        List<Product> products;

        public ProductRepository(List<Product> products)
        {
            this.products = products;
        }

        public int TotalProducts()
        {
            return this.products.Count;
        }

        public List<Product> AddNewProduct(Product newItem)
        {
            this.products.Add(newItem);
            return this.products;
        }

        public List<Product> GetProductsByType(string type)
        {
            return this.products.FindAll(x => x.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
        }

        public List<Product> DeleteByName(string name)
        {
            this.products.Remove(products.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase)));
            return this.products;
        }

        public double BuyProduct(string name, Double quantity)
        {
            var product = products.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && x.Quantity > 0 && quantity > 0 && x.Quantity >= quantity);
            if (product == null)
            {
                throw new Exception("Product not found or quantity not available");
            }
            else
            {
                return Double.Parse(product.Price.Replace(" RS", "")) * quantity;
            }
        }
      
    }
}
