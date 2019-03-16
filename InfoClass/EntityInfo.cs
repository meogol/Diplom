using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InfoClass
{
    //Да, на выходе должна получиться коллекция (в твоем случае из одного элемента) объектов класса 
    public class EntityInfo//internal class DealClassInfo
    {
        public String className { get; set; }
        /// <summary>
        /// string- Имя Филда, lFieldInfo- спиок филдов
        /// </summary>
        public Dictionary<string, FieldInfo> lFieldInfo { get; set; } = new Dictionary<string, FieldInfo>();

        public EntityInfo() { }

        public EntityInfo(string Name) {
            className = Name;
        }

    }
}
