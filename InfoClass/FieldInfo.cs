using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InfoClass
{//Она должна содержать список филдов.
    public class FieldInfo//internal class DealFieldDescription
    {
      //  public String Name { get; } // Amount
        public String TypeField { get; set; }//тип филда(Fild1, Fild2...)
        public List<ParamInfo> lParamInfo { get; set; } = new List<ParamInfo>();

        public FieldInfo() { }

        public FieldInfo(string typeField)
        {
            TypeField = typeField;
        }

        public string str()
        {
            return TypeField + " " + lParamInfo.Count.ToString();
        }
    }
}
