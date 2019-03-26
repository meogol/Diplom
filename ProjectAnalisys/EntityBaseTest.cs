using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EntityBaseTest:IFieldsEntity
    {
        public virtual void CreateFilds()
        {
            Fild1 fild1 = new Fild1();
            
            Fild3 fild3 = new Fild3();

            Fild1 fild11 = new Fild1();

            fild3.fild1 = fild1;
            fild3.fild1 = fild11;
            
        }

        public void NotCreateField()
        {
            TestFild testFild = new TestFild();
            TestFild testFild1 = new TestFild();

            testFild.fild = testFild;
        }
    }
}
