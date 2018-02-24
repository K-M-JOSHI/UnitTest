using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using InventorySystem;

namespace InventorySystemTests
{
    [TestClass]
    public class BuyProductTests
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
        public void BuyProductCheckPriceTest()
        {
            try {

                var cabbagePrice = productRepository.BuyProduct("cabbage", 2.5);
                var zucchiniPrice = productRepository.BuyProduct("zucchini", 1.5);
                Assert.AreEqual(Math.Round((20 * 2.5) + (20.5 * 1.5), 2), Math.Round(cabbagePrice + zucchiniPrice, 2));

            }
            catch (Exception e) {
                
                Assert.AreEqual("Product not found or quantity not available", e.Message.ToString());
            }
           
        }
    }
}
