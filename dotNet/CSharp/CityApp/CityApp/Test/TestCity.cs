using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CityApp.Test
{
    class TestCity
    {
        static void Main(string[] args)
        {
            CityMap map = new CityMap();
            initializeCityMap(map);
            searchConsole(map);
        }

        public static void initializeCityMap(CityMap map)
        {
            map.addCity("MUM", "Mumbai");
            map.addCity("ST", "Surat");
            map.addCity("VAPI", "Vapi");
            map.addCity("MON", "Monali");
            map.addCity("MAL", "Malad");

        }

        public static void searchConsole(CityMap map)
        {
            bool isExit = false;
            Console.WriteLine("Search Console Started for Map....");

            while (!isExit)
            {
                Console.WriteLine("Select Any Option Below: "
                    +"\n    1. to Search"
                    +"\n    2. Quit"
                    +"\n    Enter Your Choice: ");

                int choice = 0;
                const int ADD = 1, QUIT = 2;

                choice =Convert.ToInt32( Console.ReadLine());

                switch (choice)
                {
                    case ADD:
                        Console.WriteLine("Enter City Code: ");
                        string cityCode = Console.ReadLine();

                        Dictionary<City, City> cityMap = map.search(cityCode);

                        Console.WriteLine("Cities BELOW: ");

                        foreach (KeyValuePair<City,City> city in cityMap)
                        {
                            Console.WriteLine(city.Value);
                        }
                                
                        break;

                    case QUIT:
                        Console.WriteLine("The Program is now closed....!!");
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("You Have toSelect an Option");
                        break;
                }

            }
        }
    }
}
