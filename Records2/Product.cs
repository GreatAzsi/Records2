using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records2
{
    internal record Product(string Name, string Category, string Manufacturer)
    {
        private int _price { get; set; }
        private int _stock { get; set; }
        public void UpdateStock(int stock)
        {
            _stock = stock;
        }
        public int GetStock()
        {
            return _stock;
        }
        public void SetPrice(int price)
        {
            _price = price;
        }
        public int GetPrice()
        {
            return _price;
        }
        public int SummaPrice()
        {
            return _price * _stock;
        }
    }
    
    
}
