using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InfoClass
{
    //Да, на выходе должна получиться коллекция (в твоем случае из одного элемента) объектов класса 
    class EntityInfo//internal class DealClassInfo
    {
        public String className { get; set; }
        public List<FieldInfo> lFieldInfo { get; set; }

        public EntityInfo() { }

        public EntityInfo(String ClassName)
        {
            lFieldInfo = new List<FieldInfo>();
        }

        public string str()
        {
            return className + " " + lFieldInfo.ToString();
        }
    }
}
