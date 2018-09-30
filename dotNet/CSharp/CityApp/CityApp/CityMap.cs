using System;
using System.Collections.Generic;
using System.Text;

namespace CityApp
{
    class CityMap
    {
        private Dictionary<City, City> _cityBook = new Dictionary<City, City>();

        public void addCity(string cityCode,string cityDescription)
        {
            City city = new City(cityCode,cityDescription);
            _cityBook.Add(city, city);
        }

        public Dictionary<City,City> search(string cityCode)
        {
            Dictionary<City, City> matchingCity = new Dictionary<City, City>();

            foreach(KeyValuePair<City,City> city in _cityBook)
            {
                if (city.Key.CityCode.Contains(cityCode.ToUpper()))
                {
                    matchingCity.Add(city.Key, city.Value);
                }
            }

            return matchingCity;
        }
    }
}
