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
    class MethodAnalisysWalker : CSharpSyntaxWalker
    {
        /// <summary>
        /// путь к папке проекта(для записи .тхт)
        /// </summary>
        public string projectPath { get; set; }
        
        /// <summary>
        /// Класс-информация о файлах
        /// </summary>
        EntityInfo entityInfo;

        /// <summary>
        /// Семантическая модель предоставляет информацию об объектах и о типах объектов. Получаем из компиляции
        /// </summary>
        SemanticModel model;

        /// <summary>
        /// В метод передается проджект, из которого через GetCompilationAsync берем компиляцию, применяем ее дальше
        /// из проджекта выбираем файлы. 
        /// SyntaxTree- дерево синтаксиса, по нему гуляет анализатор.
        /// Visit запускает обход дерева
        /// </summary>
        /// <param name="project">Передаем проджект- содержит всю информацию о проекте, из него вытаскиваются файлы</param>
        /// <returns></returns>
        public List<EntityInfo> ProjectAnalysis(Project project)
        {
            Compilation compilation = project.GetCompilationAsync().Result;
            List<EntityInfo> lEntityInfo = new List<EntityInfo>();
            foreach (var file in project.Documents)
            {
                if (file.Name == "Entity.cs")
                {
                    SyntaxTree tree = file.GetSyntaxTreeAsync().Result;
                    model = compilation.GetSemanticModel(tree);
                    entityInfo = new EntityInfo(file.Name);
                    Visit(tree.GetRoot());
                    lEntityInfo.Add(entityInfo);
                }
            }
            return lEntityInfo;
        }

        /// <summary>
        /// В этом методе ищим нужный метод и вызываем для него VisitMethodDeclaration, определенный в базовом классе. 
        /// </summary>
        /// <param name="node">запрос для исследования дерева. Вызываетс яявнутри Visit</param>
        public void VisitMethodDeclaration(SyntaxNode node)
        {
            var methods = node.DescendantNodes().OfType<MethodDeclarationSyntax>();

            foreach (var method in methods)
            {
                string methodName = method.Identifier.ToString();

                if (methodName == "CreateFilds")
                { 
                    base.VisitMethodDeclaration(method);
                }
            }
        }

        /// <summary>
        /// Получаем информацию о типе токена, после получаем все интерфейсы этого токена и проверяем их
        /// </summary>
        /// <param name="sModel"></param>
        /// <param name="identifier">Токен, который мы анализруем. Токены содержут информацию об объектах </param>
        /// <returns></returns>
        string GetInterfacesNames(SemanticModel sModel, IdentifierNameSyntax identifier)
        {
            ITypeSymbol nodeType = sModel.GetTypeInfo(identifier).Type;
            if (nodeType == null)
                return null;
            foreach (var a in nodeType.Interfaces)
            {
                if (a.ToString() == typeof(IFild).AssemblyQualifiedName.Split(',')[0])
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
            if (nameFilds.Count() == 3)
            {
                var fildOne = nameFilds[0];
                var fildOneParam = nameFilds[1];
                var fildTwo = nameFilds[2];


                string nameFildOne = GetInterfacesNames(model, fildOne);
                string nameFildTwo = GetInterfacesNames(model, fildTwo);

                if (nameFildOne != null && nameFildTwo != null)
                {

                    ParamInfo paramInfo = new ParamInfo(fildTwo.ToString(), fildOneParam.ToString(), nameFildTwo);

                    if (entityInfo.lFieldInfo.Where(f => f.Name == fildOne.ToString()).LastOrDefault() != null)
                        entityInfo.lFieldInfo.Where(f => f.Name == fildOne.ToString()).LastOrDefault().lParamInfo.Add(paramInfo);

                    var fieldInfo = new FieldInfo(fildOne.ToString(), nameFildOne);
                    fieldInfo.lParamInfo.Add(paramInfo);
                    entityInfo.lFieldInfo.Add(fieldInfo);

                    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    System.IO.StreamWriter textFile = new System.IO.StreamWriter(@projectPath + "text.txt", true);
                    textFile.WriteLine(nameFildOne + " зависит от " + nameFildTwo);
                    textFile.Close();
                }
            }
        }
    }
}
