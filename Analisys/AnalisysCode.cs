using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
//using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphGeneratorUtil.InfoClass;
using Egar.Focus.Interface.Servers.TransactionServer;

namespace GraphGeneratorUtil
{
    public class AnalisysCode : CSharpSyntaxWalker
    {
        /// <summary>
        /// sModel Семантическая модель предоставляет информацию об объектах и о типах объектов. Получаем из компиляции
        /// </summary>
        public SemanticModel sModel { get; set; }
        public string BaseClassName { get; set; }
        public EntityInfo entityInfo { get; set; }
        public List<EntityInfo> entityInfos { get; set; } = new List<EntityInfo>();

        public AnalisysCode() { }

        public AnalisysCode(string baseClassName)
        {
            BaseClassName = baseClassName;
        }

        /// <summary>
        /// Компиляция проекта
        /// </summary>
        Compilation compilation;
        /// <summary>
        /// В метод передается проджект, из которого через GetCompilationAsync берем компиляцию, применяем ее дальше
        /// Visit запускает обход дерева
        /// </summary>
        /// <param name="project">Передаем проджект- содержит всю информацию о проекте, из него получаем компиляцию</param>
        /// <returns></returns>
        public List<EntityInfo> ProjectAnalysis(Project project)
        {
            compilation = project.GetCompilationAsync().Result;
            
            List<EntityInfo> lEntityInfo = new List<EntityInfo>();
            
            Console.WriteLine(compilation);

            foreach (var tree in compilation.SyntaxTrees)
            {
                Visit(tree.GetRoot());
            }
            
            return lEntityInfo;
        }

        /// <summary>
        /// tree-дерево, начатое с указанного узла(node)
        /// root- начальная точка обхода дерева
        /// classSymbol- реализует интерфейс Symbol, содержащий информацию об объектах
        /// implementedInterfaces- список интерфейсов
        /// в цикле, перибираем интерфейсы, если есть реализацию у объекта или родителя, интерфейса  IFieldsEntity, продолжаем обход дерева, ища филды
        /// </summary>
        /// <param name="node">узел дерева, содержит в себе весь клас, с учетом имени, нследников и интерфейсов</param>
        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var tree = node.SyntaxTree;
            sModel = compilation.GetSemanticModel(tree);
            var classSymbol = sModel.GetDeclaredSymbol(node);

            if (classSymbol.AllInterfaces.Any(i => i.ToString() == typeof(IFieldsEntity).FullName))
            {
                entityInfo = new EntityInfo(classSymbol.Name, classSymbol.ToString());
                entityInfos.Add(entityInfo);
                
                if (/*classSymbol.Name != BaseClassName*/classSymbol.Name != "FieldsEntity")
                {
                    var baseClassSyntax = tree.GetRoot().DescendantNodes().OfType<SimpleBaseTypeSyntax>().FirstOrDefault().ToString();
                    entityInfo.baseClassName = baseClassSyntax;
                }

                ////проверка чтобы избежать ситуации, когда в baseClassName попадает IFieldsEntity или имя наследника, когда IFieldsEntity, объявляется после объявления наследника, не реализующего интерфейс. 
                ////class BaseClase: (наследник)class, Iinterfase, IFieldsEntity, условие откинет наследника и первый интерфейс, Оставив поле baseClassName= null
                //if (baseClassSyntax.FirstOrDefault() != null && baseClassSyntax.Where(c => c.ToString() == typeof(IFieldsEntity).Name).FirstOrDefault()==null )
                //        entityInfo.baseClassName = baseClassSyntax.FirstOrDefault().ToString();
                
                base.VisitClassDeclaration(node);
            }
            return;
        }
        

        /// <summary>
        /// Получаем информацию о типе токена, после получаем все интерфейсы этого токена и проверяем их
        /// </summary>
        /// <param name="interfase">тип интерфейса</param>
        /// <param name="identifier">Токен, который мы анализруем. Токены содержут информацию об объектах </param>
        /// <returns></returns>

        public bool CheckRealizeInterfase(Type interfase, IdentifierNameSyntax identifier)
        {
            ITypeSymbol nodeType = sModel.GetTypeInfo(identifier).Type;
            if (nodeType == null)
                return false;

            if (nodeType.AllInterfaces.Any(i => i.ToString() == interfase.FullName))
                return true;
            
            return false;
        }

        /// <summary>
        /// метод посещает объявления методов. Проверяет название и спускается по жестко указанным узлам(BlockSyntax(все что в фигурных скобках)->ExpressionStatementSyntax(все строка присваивания объекта)->(откидывает ;,this,скобки, по итогу токенов будет лино не 3, либо последний не реализует интерфейс), далее разбивка на токены и их анализ)
        /// </summary>
        /// <param name="node"></param>
        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.Identifier.ToString() != "CreateFields")
                return;

            var blocks = node.DescendantNodes().OfType<BlockSyntax>();

            foreach (var block in blocks)
            {

                var lines = block.DescendantNodes().OfType<ExpressionStatementSyntax>().ToList();
                foreach (var line in lines)
                {
                    var nameFields = line.DescendantNodes().OfType<IdentifierNameSyntax>().ToList();
                    
                    if (nameFields.Count() != 3)
                        continue;

                    var NameFildOne = nameFields[0];
                    var NameFildOneParam = nameFields[1];
                    var NameFildTwo = nameFields[2];

                    if (!CheckRealizeInterfase(typeof(IField), NameFildOne) || !CheckRealizeInterfase(typeof(IField), NameFildTwo))
                        continue;

                    var TypeFildOne = sModel.GetTypeInfo(NameFildOne).Type.Name;
                    var TypeFildTwo = sModel.GetTypeInfo(NameFildTwo).Type.Name;

                    ParamInfo paramInfo = new ParamInfo(NameFildTwo.ToString(), NameFildOneParam.ToString(), TypeFildTwo);

                    FieldInfo fieldInfo;
                    if (entityInfo.lFieldInfo.TryGetValue(NameFildOne.ToString(), out fieldInfo))
                    {
                        fieldInfo.lParamInfo.RemoveAll(p => p.ParamName == NameFildOneParam.ToString());
                        fieldInfo.lParamInfo.Add(paramInfo);
                    }
                    else
                    {

                        fieldInfo = new FieldInfo(NameFildOne.ToString(), TypeFildOne);
                        fieldInfo.lParamInfo.Add(paramInfo);
                        entityInfo.lFieldInfo.Add(NameFildOne.ToString(), fieldInfo);
                    }
                }
            }
        }
    }
}
