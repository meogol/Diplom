using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EntityTest:IEntityTestNas
    {
        public void CreateFilds()
        {
            Fild1 fild1 = new Fild1();
            Fild2 fild22 = new Fild2();


            fild1.fild2 = fild22;
            
        }
    }
}
