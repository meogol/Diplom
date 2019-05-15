using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EntityTest2 : Entity
    {
        Fild1 fild1 { get; set; } = new Fild1();
        Fild2 fild32 { get; set; } = new Fild2();

        protected override void CreateFilds()
        {
            fild1.fild3 = fild3;
            fild1.fild2 = fild32;
            
        }
    }
}
