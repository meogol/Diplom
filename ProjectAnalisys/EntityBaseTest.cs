using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EntityBaseTest:IFieldsEntity
    {
        Fild1 fild1 { get; set; } = new Fild1();
        Fild3 fild3 { get; set; } = new Fild3();
        Fild1 fild11 { get; set; } = new Fild1();
        TestFild testFild { get; set; } = new TestFild();
        TestFild testFild1 { get; set; } = new TestFild();

        protected virtual void CreateFilds()
        {
            fild3.fild1 = fild11;
        }

        public void NotCreateField()
        {
            testFild.fild = testFild;
        }
    }
}
