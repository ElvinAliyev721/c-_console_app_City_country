using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { '!' ,'@','#','$', '%','^', '&','*',')','(','+','.','-','=','_','~','`','1','2','3','4','5','6','7','8','9','0'};
            Countries[] countries = new Countries[0];
            while (true)
            {
                Helper.Colour(ConsoleColor.DarkCyan, "Add Country -1   Add City-2   List of Cities-3   Search for City-4   Delete City-5   EXIT-Any Number big from 5 or 0");
                int menunumber;
                bool Numberconvert = int.TryParse(Console.ReadLine(), out menunumber);
                if (Numberconvert)
                {
                    if (menunumber > 5 || menunumber == 0)
                    {
                        break;
                    }
                    bool exit = true;
                    switch (menunumber)
                    {
                        case (int)Menu.AddCountry:
                            exit = true;
                            Helper.Colour(ConsoleColor.Yellow, "Add name of Country or write 'exit' for exit:");
                            string Countryname = Console.ReadLine();
                            if (Countryname.ToLower() == "exit" || String.IsNullOrEmpty(Countryname)) break;
                            for (int i = 0; i < chars.Length-1; i++)
                            {
                                for (int j = 0; j < Countryname.Length; j++)
                                {
                                    if (Countryname[j] == chars[i])
                                    {
                                        Helper.Colour(ConsoleColor.Red, "Error 404");
                                        exit = false;
                                        break;
                                    }
                                }
                                if (!exit) break;
                            }
                            if (!exit) break;
                            bool Existing = false;
                            foreach (Countries item in countries)
                            {
                                if (Countryname == item.NameCountry)
                                {
                                    Helper.Colour(ConsoleColor.Red, "Already exist");
                                    Existing = true;
                                    break;
                                }
                            }
                            if (Existing) break;
                            Helper.Colour(ConsoleColor.White, "Add papulation");
                            string Countrypapulation = Console.ReadLine();
                            int Papulation;
                            bool ConvertPapulation = int.TryParse(Countrypapulation, out Papulation);
                            if (ConvertPapulation)
                            {

                                Countries countries1 = new Countries(Countryname, Papulation);
                                Array.Resize(ref countries, countries.Length + 1);
                                countries[countries.Length - 1] = countries1;
                                Helper.Colour(ConsoleColor.Green, "Country is added");
                                break;
                            }

                            break;

                        case (int)Menu.AddCity:
                            exit = true;
                            Helper.Colour(ConsoleColor.Yellow, "Add City's name or write 'exit' for exit:");
                            string Cityname = Console.ReadLine();
                            if (Cityname.ToLower() == "exit" || String.IsNullOrEmpty(Cityname)) break;
                            for (int i = 0; i < chars.Length - 1; i++)
                            {
                                for (int j = 0; j < Cityname.Length; j++)
                                {
                                    if (Cityname[j] == chars[i])
                                    {
                                        Helper.Colour(ConsoleColor.Red, "Error 404");
                                        exit = false;
                                        break;
                                    }
                                }
                                if (!exit) break;
                            }
                            if (!exit) break;
                            Helper.Colour(ConsoleColor.White, "Add papulation:");
                            string Citypapulation=Console.ReadLine();
                            int papulatoin;
                            bool convertpapulatin = int.TryParse( Citypapulation,out papulatoin);
                            if (convertpapulatin) 
                            {
                                Cities city = new Cities(Cityname, papulatoin);
                                Helper.Colour(ConsoleColor.Yellow, "List of Country");

                                foreach (Countries item in countries)
                                {
                                    Console.WriteLine($"{item}");
                                }
                                Helper.Colour(ConsoleColor.Yellow, "Sellect Country");
                                string countryname = Console.ReadLine();
                                if (String.IsNullOrEmpty(countryname))
                                {
                                    break;
                                }
                                bool y = false;
                                foreach (Countries country in countries)
                                {
                                    if (countryname.ToLower().Trim() == country.NameCountry.ToLower() && country.NameCountry.ToLower().Trim()!=city.Name.ToLower().Trim())
                                    {

                                        country.AddCity(city);
                                        y = true;
                                    }
                                }
                                if (!y)
                                {
                                    Helper.Colour(ConsoleColor.Red, "is not real or number is bigger than country or name is same with country");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("this is not number");
                                break;
                            }
                            break;
                        case (int)Menu.ListofCities:
                            Helper.Colour(ConsoleColor.Blue, "choose country for listing-1   list of all-2   EXIT-any number");
                            int num;
                            bool convernum = int.TryParse(Console.ReadLine(), out num);
                            if (convernum)
                            {
                                if (num>2)
                                {
                                    break;
                                }
                                switch (num)
                                {
                                    case (int)menu.chooseforcountry:
                                        while (true)
                                        {
                                            Helper.Colour(ConsoleColor.DarkYellow, "List of Countries");
                                            foreach (Countries item in countries)
                                            {
                                                Console.WriteLine(item);
                                            }
                                            Helper.Colour(ConsoleColor.DarkCyan, "Choose ");
                                            string countrynam = Console.ReadLine();
                                            bool chose = false;

                                            foreach (Countries item in countries)
                                            {
                                                if (item.NameCountry == countrynam)
                                                {
                                                    item.ShowCities();
                                                    chose = true;
                                                    
                                                }
                                            }
                                            if (!chose)
                                            {
                                                Helper.Colour(ConsoleColor.Red, "Error");
                                            }
                                            else if(chose)
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    default:
                                        foreach ( Countries coun in countries)
                                        {
                                            Helper.Colour(ConsoleColor.Magenta, $"{coun}");
                                            coun.ShowCities();
                                        }
                                        break;
                                }
                            }
                            break;
                        case (int)Menu.SearchCity:
                            Helper.Colour(ConsoleColor.DarkYellow, "Name of student or write 'exit' for exit");
                            string searchCity = Console.ReadLine();
                            if (searchCity == "exit") break;
                            Helper.Colour(ConsoleColor.Green,"In which Country");
                            foreach (Countries item in countries)
                            {
                                Console.WriteLine(item);
                            }
                            Helper.Colour(ConsoleColor.Yellow, "Choose:");
                            string searchcountry = Console.ReadLine().Trim();
                            bool search = false;
                            foreach (Countries item in countries)
                            {
                                if (item.NameCountry.ToLower()==searchcountry.ToLower())
                                {
                                    item.FindCity(searchCity);
                                    search = true;
                                }
                            }
                            if (!search)
                            {
                                Helper.Colour(ConsoleColor.Red, "this Country is not real");
                            }
                            break;
                            
                        default:
                            Console.WriteLine("silmk isdediyin sheheri daxil et");
                            string a =Console.ReadLine();
                            foreach (Countries item in countries )
                            {
                                item.DeleteCity(a);
                            }

                            break;
                    }
                }
                else
                {
                    Helper.Colour(ConsoleColor.Red, "Please write true number");
                }
            }

        }
    }
}
