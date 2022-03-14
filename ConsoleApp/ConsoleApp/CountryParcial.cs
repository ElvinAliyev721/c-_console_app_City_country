using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
     partial class Countries
    {
        public void AddCity(Cities city)
        {
            int sum = 0;
            int count = 0;
            bool NotMore = false;
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i] == null)
                {
                    cities[i] = city;
                    NotMore = true;
                    Helper.Colour(ConsoleColor.Green, $"{city.Name} city added to {NameCountry}");
                    break;
                }

                else if (cities[i].Name.Trim() == city.Name.Trim())
                {
                    Helper.Colour(ConsoleColor.Red, "one country can not be contain 2 and more same named cities");
                    NotMore = true;
                    break;
                }

            }
            if (NotMore)
            {
                return; ;
            }
                    while (count < 1)
                    {
                        foreach (Cities item in cities)
                        {
                            sum += item.Papulation;
                        }
                        count++;
                    }
                sum += city.Papulation;
                if (sum <= PapulationCountry)
                {
                    Array.Resize(ref cities, cities.Length + 1);
                    cities[cities.Length - 1] = city;
                    Helper.Colour(ConsoleColor.DarkGreen, $"{city.Name} city added to {NameCountry}");
                }
                else
                {
                    Helper.Colour(ConsoleColor.Red, "papulation of city must be less than papulation of country ");
                }

            
        }
        public override string ToString()
        {
            return $"{NameCountry}";
        }

        public void ShowCities()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach (Cities city in cities)
            {
                Console.WriteLine(city);
            }
            Console.ResetColor();
        }

        public void FindCity(string nameofcity)
        {
            int count = 0;

            foreach (Cities city in cities)
            {
                
                Console.ForegroundColor = ConsoleColor.White;
                if (city.Name.ToLower()==nameofcity.ToLower())
                {
                    Helper.Colour(ConsoleColor.Blue, city.ToString());
                    count ++;
                }
                
            }
            if (count==0)
            {
                Helper.Colour(ConsoleColor.Red, "This city is not exsist");
            }

        }

        public void DeleteCity(string cityname)
        {
            bool fordelete = false;
            for (int i=0; i<cities.Length; i++)
            {

                if (cities[i]?.Name.ToLower()==cityname.ToLower())
                {
                    Console.WriteLine($"{cities[i].Name}-city is deleted from {NameCountry} country");
                    Array.Clear(cities, i, 1);
                    fordelete = true;
                    break;
                }
            }
            if (!fordelete)
            {
                Console.WriteLine($"{cityname} not founded");
               
            }
        }
        
    }
}
