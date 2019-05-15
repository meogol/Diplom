using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EntityyTest4 : EntityTest3
    {
        Fild1 fild1 { get; set; } = new Fild1();

        protected override void CreateFilds()
        {
            fild1.fild2 = fild22;
            fild3.fild1 = fild1;
            testFild.fild1 = fild1;
            fild3.fild2 = fild22;
            fild3_1.fild3 = fild3;
        }
    }
}
