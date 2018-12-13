
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// msWorkspace.WorkspaceFailed += (sender, args) => Console.WriteLine(args.Diagnostic.Message);
namespace ConsoleApp1
{
    class Program //BaseListSyntax
    {
        static void Main(string[] args)
        {
            Analisys();
            Console.WriteLine("Completed!");
            Console.ReadKey();
        }

        static void Analisys()
        {
            string solutionPath = @"C:\Users\Вера\source\repos\ConsoleApp2\ConsoleApp2.sln";//получаем солюшн.Из него возьмем все проджекты, в которых будем искать нужные файлы
            var msWorkspace = MSBuildWorkspace.Create();
            var solution = msWorkspace.OpenSolutionAsync(solutionPath).Result;

            MethodAnalisysWalker walker = new MethodAnalisysWalker();//переделанный нами волкер, бегает по дереву, подробнее внутри него

            foreach (var project in solution.Projects)
            {
                walker.projectPath= @project.FilePath.Remove(project.FilePath.LastIndexOf(@"\") + 1);//для создания фойла получим путь проджекта
                foreach (var document in project.Documents)
                {
                    SyntaxNode syntaxRoot = document.GetSyntaxRootAsync().Result;//здесь получаем дерево для исследования

                    walker.VisitSimpleBaseType(syntaxRoot);//ищем классы,реализующие IFild

                    walker.VisitMethodDeclaration(syntaxRoot);//анализируем CreateFilds
                    
                }
            }
        }
        
    }
}
