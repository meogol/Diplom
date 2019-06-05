using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphGeneratorUtil.InfoClass
{//Каждый филд должн создержать список зависимостей
    public class ParamInfo
    {
        public String FieldName { get; set; } // Amount
        public String ParamName { get; set; } // имя филда может отличаться от имени параметра
        public String FieldType { get; set; }
        public bool IsDeleted { get; set; }

        public ParamInfo()
        {

        }

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
