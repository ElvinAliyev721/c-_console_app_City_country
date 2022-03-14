using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public static class Helper
    {
        public static void Colour(ConsoleColor colour,string writing )
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(writing);
            Console.ResetColor();
        }
    }
    public enum Menu
    {
        AddCountry=1,
        AddCity,
        ListofCities, 
        SearchCity,
        DeleteCity  
           
    }
    public enum menu
    {
        chooseforcountry=1,
        listofall
    }
}
