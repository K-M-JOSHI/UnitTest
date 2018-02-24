using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventorySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemTests
{

    [TestClass]
    public class TotalNumberOfProductTests
    {
        List<Product> products;
        ProductRepository productRepository;

        [TestInitialize]
        public void InitializeUnitTest()
        {
            products = new List<Product>();
            products.Add(new Product("lettuce", "10.5 RS", 50, "Leafy green"));
            products.Add(new Product("cabbage", "20 RS", 100, "Cruciferous"));
            products.Add(new Product("pumpkin", "30 RS", 30, "Marrow"));
            products.Add(new Product("cauliflower", "10 RS", 25, "Cruciferous"));
            products.Add(new Product("zucchini", "20.5 RS", 50, "Marrow"));
            products.Add(new Product("yam", "30 RS", 50, "Root"));
            products.Add(new Product("spinach", "10 RS", 100, "Leafy green"));
            products.Add(new Product("broccoli", "20.2 RS", 75, "Cruciferous"));
            products.Add(new Product("Garlic", "30 RS", 20, "Leafy green"));
            products.Add(new Product("silverbeet", "10 RS", 50, "Marrow"));

            productRepository = new ProductRepository(products);

        }

        [TestMethod]
        public void TotalNumberOfProductTest()
        {
            Assert.AreEqual(10, productRepository.TotalProducts());
        }

        [TestMethod]
        public void AddOneProductTest()
        {
            productRepository.AddNewProduct(new Product("Potato", "10 RS", 100, "Root"));
            Assert.AreEqual(11, productRepository.TotalProducts());
        }

        [TestMethod]
        public void DeleteProductsTest()
        {
            productRepository.DeleteByName("zucchini");
            productRepository.DeleteByName("broccoli");
            Assert.AreEqual(8, productRepository.TotalProducts());
        }

    }
}