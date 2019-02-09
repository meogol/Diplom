using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InfoClass
{//Она должна содержать список филдов.
    class FieldInfo//internal class DealFieldDescription
    {
        public String Name { get; } // Amount
        public String TypeName { get; set; }//тип филда(Fild1, Fild2...)
        public List<ParamInfo> lParamInfo { get; set; }

        public FieldInfo() { }

        public FieldInfo(String name, string typeName)
        {
            Name = name;
            TypeName = typeName;
            lParamInfo = new List<ParamInfo>();
        }

        public string str()
        {
            return Name+" "+TypeName + " " + lParamInfo.Count.ToString();
        }
    }
}
