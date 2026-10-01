using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Records2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Smartphone> smartphones = new List<Smartphone>()
{
    new Smartphone("Samsung", "Galaxy S24", 2024) {Rating = 9.1 },
    new Smartphone("Apple", "iPhone 15", 2023) {Rating = 9.3 },
    new Smartphone("Xiaomi", "Redmi Note 13", 2024) {Rating = 8.4 },
    new Smartphone("Google", "Pixel 8", 2023) {Rating = 9.0 },
    new Smartphone("Samsung", "Galaxy A55", 2024) {Rating = 8.6 },
    new Smartphone("OnePlus", "OnePlus 12", 2024) {Rating = 8.9 },
    new Smartphone("Apple", "iPhone 14", 2022) {Rating = 8.8 },
    new Smartphone("Xiaomi", "Xiaomi 14", 2024) {Rating = 9.2 }
};

            smartphones[0].SetPrice(329000);
            smartphones[1].SetPrice(349000);
            smartphones[2].SetPrice(119000);
            smartphones[3].SetPrice(279000);
            smartphones[4].SetPrice(169000);
            smartphones[5].SetPrice(299000);
            smartphones[6].SetPrice(289000);
            smartphones[7].SetPrice(319000);
            smartphones.Where(x => x.GetReleaseYear() == 2024).Select(x => x.Model).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine(smartphones.OrderByDescending(x => x.Rating).Select(x => x.Model).First());
            int CountBrand(string brand)
            {
                return smartphones.Where(x => x.Brand == brand).Count();
            }

            Console.WriteLine(CountBrand("Samsung"));


            List<Hotel> hotels = new List<Hotel>()
{

    new Hotel("Grand Palace", "Budapest", 5) { Rating = 9.4 },
    new Hotel("City Hotel", "Budapest", 3) { Rating = 8.2 },
    new Hotel("Blue Sea Resort", "Split", 4) { Rating = 9.1 },
    new Hotel("Royal Beach", "Barcelona", 5) { Rating = 9.3 },
    new Hotel("Mountain View", "Salzburg", 4) { Rating = 8.8 },
    new Hotel("Central Stay", "Prague", 3) { Rating = 8.5 },
    new Hotel("Luxury Garden", "Vienna", 5) { Rating = 9.2 },
    new Hotel("Sunset Hotel", "Split", 4) { Rating = 8.9 },

};
            hotels[0].SetPricePerNight(68000);
            hotels[1].SetPricePerNight(32000);
            hotels[2].SetPricePerNight(54000);
            hotels[3].SetPricePerNight(82000);
            hotels[4].SetPricePerNight(46000);
            hotels[5].SetPricePerNight(28000);
            hotels[6].SetPricePerNight(75000);
            hotels[7].SetPricePerNight(49000);
            Console.WriteLine(hotels.OrderBy(x => x.SummaPrice(1)).Select(x => x.Name).First());
            List<string> InCity(string city)
            {
                return hotels.Where(x => x.City == city).Select(x => x.Name).ToList();
            }
            InCity("Budapest").ForEach(x => Console.WriteLine(x));

            hotels.OrderByDescending(x => x.Rating).Select(x => x.Name).Take(3).ToList().ForEach(x => Console.WriteLine(x));

            List<Laptop> laptops = new List<Laptop>()
            {
                new Laptop("Lenovo", "ThinkPad E14", "Intel i5") { Memory = 16 },
                new Laptop("Apple", "MacBook Air M3", "Apple M3") { Memory = 16 },
                new Laptop("Asus", "ROG Strix G16", "Intel i7") { Memory = 32 },
                new Laptop("Acer", "Aspire 5", "AMD Ryzen 5") { Memory = 16 },
                new Laptop("HP", "ProBook 450", "Intel i5") { Memory = 16 },
                new Laptop("Dell", "Inspiron 15", "Intel i7") { Memory = 32 },
                new Laptop("Lenovo", "IdeaPad Slim 3", "AMD Ryzen 5") { Memory = 8 },
                new Laptop("Asus", "VivoBook 15", "Intel i5") { Memory = 8 },
                new Laptop("Apple", "MacBook Pro M3", "Apple M3 Pro") { Memory = 36 },
                new Laptop("Acer", "Nitro 5", "Intel i7") { Memory = 32 },
            };
            laptops[0].SetPrice(319000);
            laptops[1].SetPrice(489000);
            laptops[2].SetPrice(649000);
            laptops[3].SetPrice(279000);
            laptops[4].SetPrice(349000);
            laptops[5].SetPrice(399000);
            laptops[6].SetPrice(249000);
            laptops[7].SetPrice(289000);
            laptops[8].SetPrice(799000);
            laptops[9].SetPrice(519000);
            Console.WriteLine(laptops.Average(x => x.GetPrice()));
            laptops.Where(x => x.GetPrice() < laptops.Average(x => x.GetPrice())).Select(x => x.Model).ToList().ForEach(x => Console.WriteLine(x));
            List<string> GetModels(int minMemory,int maxPrice)
            {
                return laptops.Where(x => x.GetPrice() <= maxPrice && x.Memory >= minMemory).Select(x => x.Model).ToList();
            }
            GetModels(16, 400000).ForEach(x => Console.WriteLine(x));
            Console.WriteLine(laptops.OrderByDescending(x => x.Memory).Select(x => x.Brand).First());

            List<Restaurant> restaurants = new List<Restaurant>()
{
    new Restaurant("Bella Italia", "Budapest", "Italian"),
    new Restaurant("Burger House", "Budapest", "Burger"),
    new Restaurant("Sakura", "Budapest", "Japanese"),
    new Restaurant("Pasta Roma", "Rome", "Italian"),
    new Restaurant("Tokyo Garden", "Vienna", "Japanese"),
    new Restaurant("Steak Corner", "Budapest", "Steak"),
    new Restaurant("Pizza Napoli", "Rome", "Italian"),
    new Restaurant("Grill House", "Vienna", "Steak"),
    new Restaurant("Sushi World", "Prague", "Japanese"),
    new Restaurant("Street Burger", "Prague", "Burger")
};
            restaurants[0].SetPrice(8500);
            restaurants[0].SetRating(9.1);
            restaurants[1].SetPrice(7500);
            restaurants[1].SetRating(8.5);
            restaurants[2].SetPrice(12000);
            restaurants[2].SetRating(9.4);
            restaurants[3].SetPrice(9500);
            restaurants[3].SetRating(8.9);
            restaurants[4].SetPrice(13500);
            restaurants[4].SetRating(9.2);
            restaurants[5].SetPrice(15000);
            restaurants[5].SetRating(9.0);
            restaurants[6].SetPrice(7000);
            restaurants[6].SetRating(8.7);
            restaurants[7].SetPrice(14000);
            restaurants[7].SetRating(8.8);
            restaurants[8].SetPrice(11000);
            restaurants[8].SetRating(9.3);
            restaurants[9].SetPrice(5000);
            restaurants[9].SetRating(8.2);

            List<string> ShowbyCategory(string category)
        {
                return restaurants.Where(x => x.Category == category).Select(x => x.Name).ToList();
            }
            ShowbyCategory("Burger").ForEach(x => Console.WriteLine(x));


            Console.WriteLine(restaurants.Where(x => x.GetRating() >= 9.0).Select(x => x.Name).Count());

            Console.WriteLine(restaurants.OrderByDescending(x => x.GetAveragePrice()).Select(x => x.Name).First());

            List<string > GetDistinctCities()
            {
                return restaurants.Select(x => x.City).Distinct().ToList();
            }
            GetDistinctCities().ForEach(x => Console.WriteLine(x));

                List<Series> series = new List<Series>()
{
    new Series("Breaking Bad", "Drama", "AMC"),
    new Series("Stranger Things", "SciFi", "Netflix"),
    new Series("The Boys", "Action", "Amazon"),
    new Series("Dark", "SciFi", "Netflix"),
    new Series("The Crown", "Drama", "Netflix"),
    new Series("Reacher", "Action", "Amazon"),

};
            series[0].AddEpisodes(62);
            series[0].SetRating(9.5);
            series[1].AddEpisodes(34);
            series[1].SetRating(8.7);
            series[2].AddEpisodes(32);
            series[2].SetRating(8.7);
            series[3].AddEpisodes(26);  
            series[3].SetRating(8.8);
            series[4].AddEpisodes(60);
            series[4].SetRating(8.6);
            series[5].AddEpisodes(24);
            series[5].SetRating(8.5);


            List<string> GetTitles(string studio)
            {
                return series.Where(x => x.Studio == studio).Select(x => x.Name).ToList();
            }
            Console.WriteLine( series.OrderByDescending(x => x.GetEpisodes()).Select(x => x.Name).First());

            Console.WriteLine(series.Where(x => x.GetEpisodes()>= 20).Average(x=> x.GetRating()));
            series.Select(x => x.Genre).Distinct().ToList().ForEach(x => Console.WriteLine(x));


            List<Product> products = new List<Product>()
{
    new Product("Galaxy S24", "Phone", "Samsung"),
    new Product("iPhone 15", "Phone", "Apple"),
    new Product("Pixel 8", "Phone", "Google"),
    new Product("ThinkPad E14", "Laptop", "Lenovo"),
    new Product("MacBook Air", "Laptop", "Apple"),
    new Product("ROG Strix", "Laptop", "Asus")
   
}; products[0].SetPrice(329000);
            products[1].SetPrice(349000);
            products[2].SetPrice(279000);
            products[3].SetPrice(319000);
            products[4].SetPrice(489000);
            products[5].SetPrice(649000);
            products[0].UpdateStock(15);
            products[1].UpdateStock(12);
            products[2].UpdateStock(8);
            products[3].UpdateStock(10);
            products[4].UpdateStock(7);
            products[5].UpdateStock(5);

            foreach(KeyValuePair<string, int>item in products.GroupBy(x => x.Category).ToDictionary(x => x.Key, x => x.Count()))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            
            foreach(KeyValuePair<string,double> item in  products.GroupBy(x => x.Manufacturer).ToDictionary(x => x.Key, x => x.Average(y => y.GetPrice())))
                {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach(KeyValuePair<string,string> item in products.GroupBy(x => x.Category).ToDictionary(x=> x.Key, x => x.OrderByDescending(y => y.GetPrice()).Select(y => y.Name).First()))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine(products.GroupBy(x=> x.Category).OrderByDescending(x => x.Sum(y =>y.GetStock())).ToDictionary(x => x.Key, x=> x.Sum(y => y.GetStock())).First().Key);
        }  
    }
}
