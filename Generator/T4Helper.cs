using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphGeneratorUtil.InfoClass;

namespace GraphGeneratorUtil.Generator
{
    partial class T4Generator
    {
        public List<EntityInfo> entity { get; set; }
        public List<HierarchyNode> hierarhy { get; set; } = new List<HierarchyNode>();

        public T4Generator(List<EntityInfo> Entity)
        {
            entity = Entity;
            
            foreach (var entityInfo in entity)
            {
                if(entityInfo.baseClassName==null)
                    hierarhy.Add(new HierarchyNode(){entity = entityInfo});
            }

            foreach (var clases in hierarhy)
            {
                if (clases.baseClase != null)
                {
                    foreach (var baseFields in clases.baseClase.lFieldInfo.Keys)
                    {
                        if (clases.entity.lFieldInfo.ContainsKey(baseFields))
                            clases.entity.lFieldInfo[baseFields].lParamInfo.Concat(clases.baseClase.lFieldInfo[baseFields].lParamInfo);
                        else
                            clases.entity.lFieldInfo.Add(baseFields, clases.baseClase.lFieldInfo[baseFields]);

                    }
                }
            }

            BuildHierarhi(hierarhy);

        }

        /// <summary>
        /// Передаем в метод базовые филды. Находим наследников для каждого базового филда. Если наследники найдены, передаем их в метод. Повторяем, пока наследники не закончатся.
        /// </summary>
        /// <param name="hierarhi">Список наследников</param>
        /// <returns></returns>
        private List<HierarchyNode> BuildHierarhi(List<HierarchyNode> hierarhi)
        {
            foreach (var baseClass in hierarhi)
            {
                var nodes = entity.Where(e => e.baseClassName == baseClass.entity.className).Select(e=>new HierarchyNode() { entity = e, baseClase = baseClass.entity }).ToList();
                if (nodes != null)
                {
                    baseClass.childs = nodes;
                    BuildHierarhi(nodes);
                }
            }

            return hierarhi;
        }
    }

    public class HierarchyNode
    {
        public EntityInfo entity { get; set; }
        public  EntityInfo baseClase { get; set; }
        public  List<HierarchyNode> childs { get; set; }
    }
}
