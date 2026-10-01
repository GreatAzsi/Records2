using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records2
{
    internal record Series(string Name, string Genre, string Studio)
    {
        private int _episodes { get; set; }
        private double _rating { get; set; }
        public void AddEpisodes(int episodes)
        {
            _episodes += episodes;
        }
        public void SetRating(double rating)
        {
            _rating = rating >= 0 && rating <= 10 ? rating : _rating;
        }
        public bool IslongSeries()
        {
            return _episodes >= 40;
        }
        public int GetEpisodes()
        {
            return _episodes;
        }
        public double GetRating()
        {
            return _rating;
        }
    }
}
