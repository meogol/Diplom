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
                Console.WriteLine();
                Console.WriteLine();
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
            var classSymbol = sModel.GetDeclaredSymbol(root.DescendantNodes().OfType<ClassDeclarationSyntax>().First());
            var implementedInterfaces = classSymbol.AllInterfaces;
            // Console.WriteLine(classSymbol.Name);
            foreach (var fullNameInterface in implementedInterfaces)
                if (fullNameInterface.ToString() == typeof(IFieldsEntity).FullName)
                {
                    entityInfo = new EntityInfo(classSymbol.Name);
                    entityInfos.Add(entityInfo);

                    base.VisitClassDeclaration(node);
                }
        }
        ///// <summary>
        ///// В этом методе ищим нужный метод и вызываем для него VisitMethodDeclaration, определенный в базовом классе. 
        ///// </summary>
        ///// <param name="node">запрос для исследования дерева. Вызываетс яявнутри Visit</param>
        //public void VisitMethodDeclaration(SyntaxNode node)
        //{
        //    var methods = node.DescendantNodes().OfType<MethodDeclarationSyntax>();

        //    foreach (var method in methods)
        //    {
        //        string methodName = method.Identifier.ToString();

        //        base.VisitMethodDeclaration(method);
        //    }
        //}

        /// <summary>
        /// Получаем информацию о типе токена, после получаем все интерфейсы этого токена и проверяем их
        /// </summary>
        /// <param name="sModel"></param>
        /// <param name="identifier">Токен, который мы анализруем. Токены содержут информацию об объектах </param>
        /// <returns></returns>
        string GetInterfacesNames(IdentifierNameSyntax identifier)
        {
            ITypeSymbol nodeType = sModel.GetTypeInfo(identifier).Type;
            if (nodeType == null)
                return null;
            foreach (var fullNameInterface in nodeType.Interfaces)
            {
                if (fullNameInterface.ToString() == typeof(IFild).FullName)
                    return nodeType.Name;
            }
            return null;
        }

        /// <summary>
        /// токены- имена филдов. соответственно первый зависит от последнего.
        /// Так же берем параметр первого объекта, и запоминаем его имя.
        /// переменные fild...хранят имена переменных
        /// переменные nameFild... хранят названия типов
        /// </summary>
        /// <param name="node">узел представляет строку операции(fild1.fild2 = fild2;) разбивается на токены, которые мы запоминаем</param>
        public override void VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            var nameFilds = node.DescendantNodes().OfType<IdentifierNameSyntax>().ToList();
            if (nameFilds.Count() != 3)
                return;

            string TypeFildOne = GetInterfacesNames(nameFilds[0]);
            string TypeFildTwo = GetInterfacesNames(nameFilds[2]);
            //Console.WriteLine(TypeFildOne + "         "+ TypeFildTwo);
            if (TypeFildOne != null && TypeFildTwo != null)
            {
                var NameFildOne = nameFilds[0];
                var NameFildOneParam = nameFilds[1];
                var NameFildTwo = nameFilds[2];

             //   Console.WriteLine(NameFildOne + "." + NameFildOneParam + "         " + NameFildTwo);

                
                ParamInfo paramInfo = new ParamInfo(NameFildTwo.ToString(), NameFildOneParam.ToString(), TypeFildTwo);

                if (!entityInfo.lFieldInfo.ContainsKey(NameFildOne.ToString()))
                {
                    FieldInfo fieldInfo = new FieldInfo(TypeFildOne);
                    fieldInfo.lParamInfo.Add(paramInfo);
                    entityInfo.lFieldInfo.Add(NameFildOne.ToString(), fieldInfo);
                }
                entityInfo.lFieldInfo[NameFildOne.ToString()].lParamInfo.Add(paramInfo);
            }
            
        }
    }
}
