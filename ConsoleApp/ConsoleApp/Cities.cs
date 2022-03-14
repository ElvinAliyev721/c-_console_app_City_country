using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Cities
    {
        public string Name { get; set; }
        public int Papulation { get; set; }

        public readonly int Id;
        private static int count;
        public Cities()
        {
            count++;
            Id = count;

        }
        public Cities(string name, int papulation):this()
        {
            Name = name;
            Papulation = papulation;

        }
        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
