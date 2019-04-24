using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EntityTest3 : EntityTest2
    {
        Fild1 fild1 { get; set; } = new Fild1();
        Fild1 fild11 { get; set; } = new Fild1();
        TestFild testFild1 { get; set; } = new TestFild();

        protected override void CreateFilds()
        {
            fild3.fild1 = fild1;
            fild3.fild1 = fild11;
        }

        public void NotCreateField()
        {
            testFild.fild = testFild;
        }
    }
}
