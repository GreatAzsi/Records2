using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records2
{
    internal record Smartphone(string Brand, string Model, int ReleaseYear)
    {       
     
        private int _releaseYear { get; init; } = ReleaseYear;
        private int _price { get; set; }
        public Double Rating { get; set; }
        public int GetReleaseYear()
        {
            return _releaseYear;
        }
        public void SetPrice(int price)
        {
            _price = price;

        }
        public void SetDiscount(int discount)
        {
            _price = _price * (discount / 100);
        }
    }
}
