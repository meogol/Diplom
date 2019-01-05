using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodAnalisysWalker : CSharpSyntaxWalker
    {
        /// <summary>
        /// путь к папке проекта(для записи .тхт)
        /// </summary>
        public string projectPath { get; set; }

        SemanticModel model;
        public void ProjectAnalysis(Project project)
        {
            Compilation compilation = project.GetCompilationAsync().Result;
            foreach (var file in project.Documents)
            {
                if (file.Name== "Entity.cs") {
                    SyntaxTree tree = file.GetSyntaxTreeAsync().Result;
                    model = compilation.GetSemanticModel(tree);
                    Visit(tree.GetRoot()); }
            }
        }
        
        public void VisitMethodDeclaration(SyntaxNode node)//перегружаем visitMethodDeclaration под наше дерево и ищем нужный метод. дефолтный визит будет гулять по дереву за нас
        {
            var methods = node.DescendantNodes().OfType<MethodDeclarationSyntax>();

            foreach (var method in methods)
            {
                string methodName = method.Identifier.ToString();

                if (methodName == "CreateFilds")
                    base.VisitMethodDeclaration(method);
            }
        }

        string GetInterfacesNames(SemanticModel sModel, IdentifierNameSyntax identifier)//получаем реализуемые объектом интерфейсы
        {//проверяем, есть ли среди них IFild, если есть, возвращаем имя класса
            ITypeSymbol nodeType = sModel.GetTypeInfo(identifier).Type;
            if (nodeType == null)
                return null;
            foreach (var a in nodeType.Interfaces.Select(p => p.Name).ToList())
                if (a == "IFild")
                    return nodeType.Name;
            return null;
        }

        public override void VisitExpressionStatement(ExpressionStatementSyntax node)
        {//узел представляет строку операции(fild1.fild2 = fild2;) из этого берем первый и последний токен- имена филдов. соответственно первый зависит от последнего
            var fildOne = node.DescendantNodes().OfType<IdentifierNameSyntax>().FirstOrDefault();
            var fildTwo = node.DescendantNodes().OfType<IdentifierNameSyntax>().LastOrDefault();

            string nameFildOne = GetInterfacesNames(model, fildOne);
            string nameFildTwo = GetInterfacesNames(model, fildTwo);
            if (nameFildOne != null && nameFildTwo != null)
            {//то пишем в файл
                System.IO.StreamWriter textFile = new System.IO.StreamWriter(@projectPath + "text.txt", true);
                textFile.WriteLine(nameFildOne + " зависит от " + nameFildTwo);
                textFile.Close();
            }
        }
        
    }
}
