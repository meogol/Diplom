using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Fild3 : IFild
    {
        public Fild2 fild2 { get; set; }
        public Fild1 fild1 { get; set; }
    }

    public class Fild3_1 : IFild {

        public Fild3 fild3 { get; set; }
    }

    public class Fild3_2 : ITest { }

}
