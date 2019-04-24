using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Entity: IFieldsEntity
    {
        public Fild1 Fild1 { get; set; } = new Fild1();
        public Fild2 fild22 { get; set; } = new Fild2();
        public Fild3 fild3 { get; set; } = new Fild3();
        public Fild3_1 fild3_1 { get; set; } = new Fild3_1();
        public TestFild testFild { get; set; } = new TestFild();
        public Fild3_2 fild3_2 { get; set; } = new Fild3_2();

        void Main(string[] args)
        {
            CreateFilds();
        }

        protected virtual void CreateFilds()
        {
            Fild1.fild2 = fild22;
            fild3.fild1 = Fild1;
            testFild.fild1 = Fild1;
            fild3.fild2 = fild22;
            fild3_1.fild3 = fild3;
        }
    }
}
