using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records2
{
    internal record Hotel(string Name, string City, int Stars)
    {
        private int _stars { get; init; }= Stars;
        private int _pricePerNight { get; set; }
        public double Rating { get; set; }
        public bool Is4StarorBetter()
        {
            return _stars >= 4;
        }
        public void SetPricePerNight(int price)
        {
            _pricePerNight = price;
        }
        public int SummaPrice(int night)
        {
            return _pricePerNight*night;
        }
    }
}
