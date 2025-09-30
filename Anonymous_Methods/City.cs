using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDelegate
{
    class City
    {
        private string city_name;
        private int postal_code;

        public City(int postal_code, string city_name)
        {
            this.postal_code = postal_code;
            this.city_name = city_name;
        }
        
        public string City_Name { get { return city_name; } }
        public int Postal_Code { get { return postal_code; } }
    }

    class Program {

        public delegate string ReturnCityPostalCode(string city);

        static void AddCities(Dictionary<int, string> cities)
        {
            cities.Add(5300, "Gabrovo");
            cities.Add(1000, "Sofia");
            cities.Add(4000, "Plovdiv");
            cities.Add(3000, "Vratsa");
            cities.Add(9000, "Varna");
            cities.Add(8000, "Burgas");
            cities.Add(6000, "Stara Zagora");
            cities.Add(7000, "Ruse");
        }



        static void Main(string[] args)
        {
            Dictionary<int, string> cities = new Dictionary<int, string>();

            AddCities(cities);

            List<City> city = new List<City>();

            foreach (KeyValuePair<int, string> pair in cities)
            {
                city.Add(new City(pair.Key, pair.Value));
            }
            
            Console.Write("Enter city: ");
            string user_input = Console.ReadLine();

            ReturnCityPostalCode city_postal_code = delegate (string input)
            {
                foreach (City c in city)
                {
                    if (input == c.City_Name)
                    {
                        return $"City: {c.City_Name}, Postal code: {c.Postal_Code}";
                    }
                }

                return "No postal code for this city";
            };

            string postal_code = city_postal_code(user_input);
            Console.WriteLine(postal_code);
        }
    }
}
