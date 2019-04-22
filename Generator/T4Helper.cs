using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.InfoClass;

namespace ConsoleApp1.Generator
{
    partial class T4Generator
    {
        public List<EntityInfo> entity { get; set; }

        public T4Generator(List<EntityInfo> Entity)
        {
            entity = Entity;
            AddBaseField();
        }

        /// <summary>
        /// Находим родителя для наследника и проверяем список филдов в наследнике. Если филд уже существует в списке
        /// наследника, объединяем его зависимости с зависимостями родителя, в противном случае добавляем филд в список
        /// наследника. Метод выполняется перед началом генерации.
        /// </summary>
        private void AddBaseField()
        {
            foreach (var clases in entity)
            {
                var fields = entity.FirstOrDefault(c => c.className == clases.baseClassName);
                if (fields != null)
                {
                    foreach (var baseFields in fields.lFieldInfo.Keys)
                    {
                        if (clases.lFieldInfo.ContainsKey(baseFields))
                            clases.lFieldInfo[baseFields].lParamInfo.Concat(fields.lFieldInfo[baseFields].lParamInfo);
                        else
                            clases.lFieldInfo.Add(baseFields, fields.lFieldInfo[baseFields]);
                        
                    }
                }
            }
        }
    }
}
