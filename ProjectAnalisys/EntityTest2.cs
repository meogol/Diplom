using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EntityTest2 : Entity, ITest2, IFieldsEntity
    {
        public void CreateFilds()
        {
            Fild1 fild1 = new Fild1();
            Fild2 fild32 = new Fild2();
            Fild3 fild3=new Fild3();

            fild1.fild3 = fild3;
            fild1.fild2 = fild32;
            
        }
    }
}
