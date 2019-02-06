using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;
using ConsoleApp1.InfoClass;

namespace ConsoleApp1
{
    class AnalisysCode : CSharpSyntaxWalker
    {
        /// <summary>
        /// sModel Семантическая модель предоставляет информацию об объектах и о типах объектов. Получаем из компиляции
        /// </summary>
        SemanticModel sModel;

        EntityInfo entityInfo;
        public List<EntityInfo> entityInfos { get; set; } = new List<EntityInfo>();

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

            foreach(var tree in compilation.SyntaxTrees)
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
            var root = tree.GetRoot();
            sModel = compilation.GetSemanticModel(node.SyntaxTree);
            var classSymbol = sModel.GetDeclaredSymbol(node);
            if(classSymbol.AllInterfaces.Any(i=>i.ToString()==typeof(IFieldsEntity).FullName))
            {
                entityInfo = new EntityInfo(classSymbol.Name);
                entityInfos.Add(entityInfo);

                base.VisitClassDeclaration(node);
            }
        }
        
        /// <summary>
        /// Получаем информацию о типе токена, после получаем все интерфейсы этого токена и проверяем их
        /// </summary>
        /// <param name="interfase">тип интерфейса</param>
        /// <param name="identifier">Токен, который мы анализруем. Токены содержут информацию об объектах </param>
        /// <returns></returns>

        bool CheckRealizeInterfase(Type interfase, IdentifierNameSyntax identifier)
        {
            ITypeSymbol nodeType = sModel.GetTypeInfo(identifier).Type;
            if (nodeType == null)
                return false;

            if (nodeType.Interfaces.Any(i => i.ToString() == interfase.FullName))
                return true;
            return false;
        }

        /// <summary>
        /// токены- имена филдов. соответственно первый зависит от последнего.
        /// Так же берем параметр первого объекта, и запоминаем его имя.
        /// переменные Namefild...хранят имена переменных
        /// переменные TypeFild... хранят названия типов
        /// </summary>
        /// <param name="node">узел представляет строку операции(fild1.fild2 = fild2;) разбивается на токены, которые мы запоминаем</param>
        public override void VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            var nameFilds = node.DescendantNodes().OfType<IdentifierNameSyntax>().ToList();
            if (nameFilds.Count() != 3)
                return;

            var NameFildOne = nameFilds[0];
            var NameFildOneParam = nameFilds[1];
            var NameFildTwo = nameFilds[2];
            
            if (!CheckRealizeInterfase(typeof(IFild), NameFildOne) && !CheckRealizeInterfase(typeof(IFild), NameFildTwo))
                return;

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
                fieldInfo = new FieldInfo(TypeFildOne);
                fieldInfo.lParamInfo.Add(paramInfo);
                entityInfo.lFieldInfo.Add(NameFildOne.ToString(), fieldInfo);
            }
        }
    }
}
