using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InfoClass
{//Она должна содержать список филдов.
    public class FieldInfo//internal class DealFieldDescription
    {
        /// <summary>
        /// добавим имя, ибо неудобно пользоваться
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// тип филда(Fild1, Fild2...)
        /// </summary>
        public String TypeField { get; set; }
        /// <summary>
        /// лист зависимостей
        /// </summary>
        public List<ParamInfo> lParamInfo { get; set; } = new List<ParamInfo>();

        public FieldInfo() { }

        public FieldInfo(string name, string typeField)
        {
            Name = name;
            TypeField = typeField;
        }

        public string str()
        {
            return TypeField + " " + lParamInfo.Count.ToString();
        }
    }
}
