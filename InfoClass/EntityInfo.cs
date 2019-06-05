using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphGeneratorUtil.InfoClass
{
    //Да, на выходе должна получиться коллекция (в твоем случае из одного элемента) объектов класса 
    public class EntityInfo//internal class DealClassInfo
    {
        /// <summary>
        /// Имя базового класса
        /// </summary>
        public string baseClassName { get; set; }
        /// <summary>
        /// полное имя класса
        /// </summary>
        public  string classFullName { get; set; }
        /// <summary>
        /// имя класса
        /// </summary>
        public String className { get; set; }
        /// <summary>
        /// string- Имя Филда, lFieldInfo- спиок филдов
        /// </summary>
        public Dictionary<string, FieldInfo> lFieldInfo { get; set; } = new Dictionary<string, FieldInfo>();

        public EntityInfo() { }

        public EntityInfo(string Name, string fullName) {
            className = Name;
            classFullName = fullName;
        }

    }
}
