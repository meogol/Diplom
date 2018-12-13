using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fild
    {
        public string NameType { get; set; }
        public string Name { get; set; }

        public Fild() { }

        public Fild(string nameType,string name)
        {
            NameType = nameType;
            Name = name;
        }
    }
}
