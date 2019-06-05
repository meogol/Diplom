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
            
            BuildHierarhi(hierarhy);

            Console.WriteLine("helper");
            foreach (var a in entity)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("class " + a.className);
                Console.WriteLine("base " + a.baseClassName);
                foreach (var b in a.lFieldInfo.Keys)
                {
                    Console.WriteLine("name " + b + "      type " + a.lFieldInfo[b].TypeField);
                    foreach (var c in a.lFieldInfo[b].lParamInfo)
                    {
                        Console.WriteLine("parrent " + c.FieldName + "     type " + c.FieldType + "     param " + c.ParamName);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("helper");
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

                    foreach(var childNode in nodes)
                    {
                        var childEntity = childNode.entity;
                        foreach (var nameBaseFld in baseClass.entity.lFieldInfo.Keys)
                        {
                            if (childNode.entity.lFieldInfo.Keys.Contains(nameBaseFld))
                            {
                                childEntity.lFieldInfo[nameBaseFld].lParamInfo.Concat(baseClass.entity.lFieldInfo[nameBaseFld].lParamInfo);
                            }
                            else
                            {
                                childEntity.lFieldInfo.Add(nameBaseFld, baseClass.entity.lFieldInfo[nameBaseFld]);
                            }
                        }
                    }
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
