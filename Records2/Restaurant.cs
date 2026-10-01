using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records2
{
    internal record Restaurant(string Name, string City, string Category)
    {
        private int _averagePrice { get; set; }
        private double _rating { get; set; }

        public void SetRating(double rating)
        {
           _rating = rating >= 0 && rating <= 10 ? rating : _rating;
        }
        public bool IsExpensive()
        {
            return _averagePrice >= 12000;
        }
        public void SetPrice(int price)
        {
            _averagePrice = price;
        }
       public double GetRating()
        {
            return _rating;
        }
        public double GetAveragePrice() {
            return _averagePrice;

        }
    }
}
