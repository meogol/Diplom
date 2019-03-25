using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.InfoClass;

namespace ConsoleApp1.Generator
{
    partial class T4Generator
    {
        public List<EntityInfo> entity { get; set; }

        public T4Generator(List<EntityInfo> Entity)
        {
            entity = Entity;
        }
    }
}
