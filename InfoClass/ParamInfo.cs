using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InfoClass
{//Каждый филд должн создержать список зависимостей
    class ParamInfo
    {
        public String FieldName { get; set; } // Amount
        public String ParamName { get; set; } // имя филда может отличаться от имени параметра
        public String FieldType { get; set; }

        public ParamInfo(string fieldName, string paramName, string fieldType)
        {
            this.FieldName = fieldName;
            this.ParamName = paramName;
            FieldType = fieldType;
        }

        public string str()
        {
            return FieldName + " " +FieldType+"."+ ParamName;
        }
    }
}
