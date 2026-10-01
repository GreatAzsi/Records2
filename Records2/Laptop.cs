using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records2
{
    internal record Laptop(string Brand, string Model, string Processor)
    {
        private string _processor { get; init; } = Processor;
        private int _price { get; set; }
        public int Memory { get; set; }

        public string GetProcessor()
        {
            return _processor;
        }
        public void SetPrice(int price)
        {
            _price = price;
        }
        public void UpdateMemory(int memory)
        {
            Memory += memory;
        }
        public int GetPrice()
        {
            return _price;
        }   
    }
}
