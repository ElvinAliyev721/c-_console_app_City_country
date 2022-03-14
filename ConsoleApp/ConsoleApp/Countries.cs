using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    partial class Countries
    {
        public string NameCountry { get; set; }
        public int PapulationCountry { get; set; }

        public readonly int IdCountry;
        private static int Count;
        private Cities[] cities;

        public Countries()
        {
            Count++;
            IdCountry = Count;
            cities = new Cities[0];

        }
        public Countries(string nameCountry,int papulationCountry):this()
        {
            NameCountry = nameCountry;
            PapulationCountry = papulationCountry;

        }
       
    }
}
