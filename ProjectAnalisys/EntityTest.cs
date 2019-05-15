using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EntityTest : Entity
    {
        public Fild1 fild1 { get; set; } = new Fild1();
        public Fild2 fild222 { get; set; } = new Fild2();

        protected  override  void CreateFilds()
        {
            fild1.fild2 = fild222;
        }
    }
}
