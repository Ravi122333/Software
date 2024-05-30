using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Quality_Assignment2
{
    public class Product
    {
        // Attributes
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        private int _stock;

        // Constructor
        public Product(int productID, string productName, decimal price, int stock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            _stock = stock;
        }

        // Stock Methods
        public int GetStock()
        {
            return _stock;
        }

        public void IncreaseStock(int amount)
        {
            _stock += amount;
        }

        public void DecreaseStock(int amount)
        {
            if (_stock >= amount)
                _stock -= amount;
            else
                throw new InvalidOperationException("Not enough stock available.");
        }
    }
}
