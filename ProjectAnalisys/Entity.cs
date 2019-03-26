using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Entity: IFieldsEntity
    {
        static void Main(string[] args)
        {
            CreateFilds();
        }

        static private void CreateFilds()
        {
            Fild1 fild1=new Fild1();
            Fild2 fild22=new Fild2();
            

            fild1.fild2 = fild22;

            Fild3 fild3 = new Fild3();
            Fild3_1 fild3_1 = new Fild3_1();
            
            fild3.fild1 = fild1;

            TestFild testFild = new TestFild();
            Fild3_2 fild3_2 = new Fild3_2();

            testFild.fild1 = fild1;

            fild3.fild2 = fild22;
            fild3_1.fild3 = fild3;
        }
    }
}
