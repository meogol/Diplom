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
        /// Строим иерархию и
        /// Находим родителя для наследника и проверяем список филдов в наследнике. Если филд уже существует в списке
        /// наследника, объединяем его зависимости с зависимостями родителя, в противном случае добавляем филд в список
        /// наследника. Метод выполняется перед началом генерации.
        /// </summary>
        private void AddBaseField()
        {
            var hierarhi = entity.Where(c => c.baseClassName == null).ToList();
            entity = BuildHierarhi(hierarhi);

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
        /// <summary>
        /// выстраиваем список таким образом, чтобы первыми эллементами были родители, а последними наследники.
        /// Изначально список содержит только базовые классы. Находим их наследников и добавляем в список, удаляя из начального списка. Продолжаем пока начальный список не станет пустым
        /// </summary>
        /// <param name="hierarhi">отсортированный список</param>
        /// <returns></returns>
        private List<EntityInfo> BuildHierarhi(List<EntityInfo> hierarhi)
        {
            foreach (var entityClass in entity)
            {
                if (hierarhi.Where(h=>h.className==entityClass.baseClassName).FirstOrDefault()!=null)
                {
                    hierarhi.Add(entityClass);
                }
            }

            foreach (var baseClases in hierarhi)
            {
                entity.Remove(baseClases);
            }

            if (entity.Count != 0)
                BuildHierarhi(hierarhi);

            return hierarhi;
        }
    }
}
